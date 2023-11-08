
document.addEventListener("DOMContentLoaded", function () {
    const entranceMusic = document.getElementById("entrance-music");

    entranceMusic.play();

    window.addEventListener("beforeunload", function () {
        entranceMusic.pause();
    });

    const overlay = document.querySelector(".overlay");
    const textDisplay = document.getElementById("text-display");
    const textArray = [
        "In this galaxy, there exists beings known as the 'Aeons'. They shape reality, erase stars, leaving their mark in countless 'worlds'.",
        "You—a special traveler, will journey alongside companions inheriting the spirit of 'exploration'. Together, you'll board the Starvault Train, traversing the galaxy, following the path once taken by a 'Aeon'.",
        "From here, you'll delve into new civilizations, forge connections with new comrades, embarking on fresh adventures between worlds, each more wondrous and peculiar than the last. All that you seek to know, you will find amidst the constellations.",
        "So, are you prepared to embark on this journey of 'exploration'?",
        "May this voyage ultimately lead you to the stars."
    ];

    let currentIndex = 0;

    function displayText() {
        if (currentIndex < textArray.length) {
            const text = textArray[currentIndex];
            textDisplay.textContent = text;

            if (currentIndex === textArray.length - 1) {
                textDisplay.classList.add("last-sentence");
            } else {
                textDisplay.classList.remove("last-sentence");
            }

            currentIndex++;
            setTimeout(displayText, 5780); 
        } else {
            overlay.style.display = "none";
        }
    }
    displayText();
});

