document.addEventListener("DOMContentLoaded", function () {

    const regions = document.querySelectorAll('.region');
    const popupContainer = document.getElementById('popup-container');
    popupContainer.style.display = 'none';
    let isPopupVisible = false;

    regions.forEach(region => {
        region.addEventListener('click', (event) => {
            const title = event.target.dataset.title;
            const popupContainer = document.getElementById('popup-container');
            const popupTitle = document.getElementById('popup-title');
            
            const popupImage = document.getElementById('popup-image');
         
            const popupAudioFirst = document.getElementById('popup-audio-first');
            const popupAudioSecond = document.getElementById('popup-audio-second');
            const popupAudioThird = document.getElementById('popup-audio-third');
            const popupDescription = document.getElementById('popup-description');
            popupAudioFirst.pause();
            popupAudioSecond.pause();
            popupAudioThird.pause();

            if (title === 'first') {
                popupTitle.textContent = 'Herta Space Station';
                popupImage.src = '/Image/Planets/Planets-space.jpg';             
                popupAudioFirst.play();
                popupAudioFirst.style.display = 'block';
                popupAudioSecond.style.display = 'none';
                popupAudioThird.style.display = 'none';
                popupDescription.textContent = 'Not content with the laws of the common world, the Genius Society\'s Herta set her sights on the unexplained existences of the galaxy, expecting those distant mysteries to satisfy her curiosity.To this end, Herta led the establishment of a museum - like starship and launched it towards the orbit, starting the research work to seal all strange existences among the stars.And the famous Herta Space Station was born.';
            } else if (title === 'second') {
                popupTitle.textContent = 'Jarilo-VI';
                popupImage.src = '/Image/Planets/Planets-ice.png';           
                popupAudioSecond.play();
                popupAudioFirst.style.display = 'none';
                popupAudioSecond.style.display = 'block';
                popupAudioThird.style.display = 'none';
                popupDescription.textContent = 'Traversing across the snow plains, you can get a full view of Belobog, the only spot on the ice-cold world of Jarilo - Vl that barely fits the definition of "a warm place. As the only remaining city with human civilization, Belobog has been given many grandiose titles: the last bastion of mankind against the Eternal Freeze, the land blessed by Qlipoth...';
            } else if (title === 'third') {
                popupTitle.textContent = 'The Xianzhou Luofu';
                popupImage.src = '/Image/Planets/Planets-Xianzhou.jpg';
               
                popupAudioThird.play();
                popupAudioFirst.style.display = 'none';
                popupAudioSecond.style.display = 'none';
                popupAudioThird.style.display = 'block';
                popupDescription.textContent = 'The Xianzhou Luofu is one of the six flagships of the Xianzhou Alliance. It sails in the endless ocean of stars like a one - way arrow, shooting toward the Lord of the Hunt\'s destined enemy';
            }
            popupContainer.style.display = 'block';
        });
        if (isPopupVisible) {
            popupContainer.style.display = 'none';
            isPopupVisible = false;
        }
    });
});