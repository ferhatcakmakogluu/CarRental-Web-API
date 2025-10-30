using Autofac;
using Autofac.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayer.API.Filters;
using NLayer.API.Middlewares;
using NLayer.API.Modules;
using NLayer.Repository;
using NLayer.Service.Mapping;
using NLayer.Service.Validation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(
    options => options.Filters.Add(new ValidateFilterAttribute())
)
.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<UserDtoValidator>());

// Sistemin default filterini kapat
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddScoped(typeof(NotFoundFilter<>));

// Autofac implement
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => 
    containerBuilder.RegisterModule(new RepoServiceModule()));

// AutoMapper dahil et
builder.Services.AddAutoMapper(typeof(MapProfile));

// PostgreSQL DbContext
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

// Health Check endpoint
builder.Services.AddHealthChecks()
    .AddNpgSql(builder.Configuration.GetConnectionString("PostgresConnection")!);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Migration'ları otomatik uygula (Production'da)
if (app.Environment.IsProduction())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var logger = services.GetRequiredService<ILogger<Program>>();
        
        try
        {
            logger.LogInformation("Starting database migration...");
            var context = services.GetRequiredService<AppDbContext>();
            
            // Migration'ları uygula
            await context.Database.MigrateAsync();
            
            logger.LogInformation("Database migration completed successfully");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while migrating the database");
            throw; // Uygulama başlamasın
        }
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS Redirection - Nginx kullanıyorsanız bu satırı kaldırın
// Docker içinde HTTP kullanıyorsanız bu gerekli değil
if (app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

// Kendi middleware'inizi kullanın (yazım hatasını düzeltin)
app.UserCustomEsception(); // UserCustomEsception() değil!

app.UseAuthorization();

// Health Check endpoint
app.MapHealthChecks("/health");

app.MapControllers();

app.Run();