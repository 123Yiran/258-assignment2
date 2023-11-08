var isAnimating = false;
var currentPosition = 0;
function moveCarousel(direction) {
    if (isAnimating) return; 
    isAnimating = true; 

    var slider = document.querySelector('.slider');
    var totalItems = document.querySelectorAll('.item').length;
    var itemWidth = document.querySelector('.item').clientWidth;
    var visibleItems = 3; 

    if (direction === 'right' && currentPosition < totalItems - visibleItems) {
        currentPosition++;
    } else if (direction === 'left' && currentPosition > 0) {
        currentPosition--;
    }

    var transformValue = -currentPosition * itemWidth;

   
    slider.addEventListener('transitionend', function () {
        isAnimating = false;
    });

    slider.style.transform = 'translateX(' + transformValue + 'px)';
}
function navigateToURL(url) {
    window.location.href = url;
}
