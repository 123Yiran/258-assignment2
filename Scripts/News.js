var currentPosition = 0;

function moveCarousel(direction) {
    var slider = document.querySelector('.slider');
    var totalItems = document.querySelectorAll('.item').length;
    var itemWidth = document.querySelector('.item').clientWidth;
    var visibleItems = 3; // Number of visible items

    if (direction === 'right' && currentPosition < totalItems - visibleItems) {
        currentPosition++;
    } else if (direction === 'left' && currentPosition > 0) {
        currentPosition--;
    }

    var transformValue = -currentPosition * itemWidth;
    slider.style.transform = 'translateX(' + transformValue + 'px)';
}
function navigateToURL(url) {
    window.location.href = url;
}
