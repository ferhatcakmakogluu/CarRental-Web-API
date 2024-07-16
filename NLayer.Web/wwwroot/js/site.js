// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const checkboxes = document.querySelectorAll('.checkbox input');
const sidebar = document.querySelector('.sidebar');
const menuBtn = document.getElementById('menuToggle');

checkboxes.forEach(c => {
    c.addEventListener("change", () => {
        const label = document.querySelector(`label[for="${c.name}"]`);
        if (c.checked) {
            label.style.color = '#1A1E20';
        } else {
            label.style.color = '#808487';
        }
    });
});

menuBtn.addEventListener('click', () => {
    sidebar.style.left = "0px";
});

document.addEventListener('click', (event) => {
    const isClickInside = sidebar.contains(event.target) || menuBtn.contains(event.target);

    if (!isClickInside) {
        sidebar.style.left = "-172px";
    }
});
