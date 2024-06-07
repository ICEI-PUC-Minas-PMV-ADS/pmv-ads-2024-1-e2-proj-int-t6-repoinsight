document.addEventListener("DOMContentLoaded", function() {
    // Get the button and the menu
    const userMenuButton = document.getElementById('user-menu-button');
    const userMenu = document.querySelector('[role="menu"][aria-labelledby="user-menu-button"]');

    // Function to toggle the menu visibility
    function toggleUserMenu() {
        const isExpanded = userMenuButton.getAttribute('aria-expanded') === 'true';
        userMenuButton.setAttribute('aria-expanded', !isExpanded);
        userMenu.classList.toggle('hidden');
    }

    // Add event listener to the button
    userMenuButton.addEventListener('click', function(event) {
        event.stopPropagation(); // Prevent the click from propagating to the document
        toggleUserMenu();
    });

    // Hide the menu when clicking outside of it
    document.addEventListener('click', function(event) {
        if (!userMenu.contains(event.target) && event.target !== userMenuButton) {
            if (userMenuButton.getAttribute('aria-expanded') === 'true') {
                userMenuButton.setAttribute('aria-expanded', 'false');
                userMenu.classList.add('hidden');
            }
        }
    });
});