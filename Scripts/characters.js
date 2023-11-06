
const observer = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
        if (entry.isIntersecting) {
           
            const contentId = entry.target.getAttribute('data-content');
            if (contentId === 'content1') {
                handleImageClickAndScroll(1, 'section1');
                const icon1 = document.querySelector('.icon-Kong img:nth-child(1)');
                icon1.click();
                const icon4 = document.querySelector('.icon-bo img:nth-child(4)');
                icon4.click();
            } if (contentId === 'content2') {
                
                handleImageClickAndScroll(2, 'section2');
                const icon2 = document.querySelector('.icon-bo img:nth-child(1)');
                icon2.click();
                const icon3 = document.querySelector('.icon-lo img:nth-child(1)');
                icon3.click();
               
            }
            if (contentId === 'content3') {
                handleImageClickAndScroll(3, 'section3');
                const icon3 = document.querySelector('.icon-lo img:nth-child(1)');
                icon3.click();
                
            }
        }
    });
}, { threshold: 0.5 });

const section1 = document.getElementById('section1');
if (section1) {
    section1.setAttribute('data-content', 'content1');
    observer.observe(section1);
}
const section2 = document.getElementById('section2');
if (section2) {
    section2.setAttribute('data-content', 'content2');
    observer.observe(section2);
}
const section3 = document.getElementById('section3');
if (section3) {
    section3.setAttribute('data-content', 'content3');
    observer.observe(section3);
}



function handleImageClickAndScroll(contentId, sectionId) {
   
    handleImageClick(contentId);
   
    scrollToPosition(sectionId);
}

function scrollToPosition(sectionId) {
    const section = document.getElementById(sectionId);
    if (section) {
        section.scrollIntoView({ behavior: "smooth" });
    }
}

function handleImageClick(selectedIndex) {

    const images = document.querySelectorAll(".animate");
   
    images.forEach((image) => {
        image.style.transform = "scale(1.0)"; 
    });

    images.forEach((image, index) => {
        if (index === selectedIndex - 1) {
            image.style.transform = "scale(1.2)"; 
        } else {
            image.style.transform = "scale(0.8)"; 
        }
    });
    
}


const icons = document.querySelectorAll('.icon-space');
const rightImage = document.getElementById('right-image-chararcter1');
const text1 = document.getElementById('text1');
const text1T = document.getElementById('text1-2');
const title1 = document.getElementById('title1');

icons.forEach((icon, index) => {
    icon.addEventListener('click', () => {
        let imageUrl = "";
        let textContent = "";
        let textWord = "";
        let textTitle = "";
        if (index === 0) {
            textTitle = 'Herta';
            textWord = 'Herta Space Station\'s true master.\r\nAs the human with the highest IQ on The Blue, she only does\r\nwhat she\'s interested in, dropping whatever project immediately\r\nthe moment she loses interest - the best example being the\r\nspace station.\r\nShe typically appears in the form of a remote-controlled puppet.\r\n\"It\'s about seventy percent similar to how I looked as a child.\"\r\n--Herta';
            textContent = 'I\'m already perfect,\nso what else should I do? ';
            imageUrl = "/Image/CharactersShow/Heita.png"; 
        } else if (index === 1) {
            textTitle = 'Asta';
            textWord = 'A fiercely inquisitive and energetic young girl, she is the Lead\r\nResearcher of Herta Space Station.\r\nWhether it is managing opinionated staff, or courteously but,\r\nfirmly responding to the Intelligentsia Guild, Asta handles it all\r\neffortlessly.\r\nAfter all. commanding a space station is much easier than taking\r\nover her family business!';
            textContent = 'The \'tortoise\' galaxies are those that slooowly give birth to new stars. The ones that use up their fuel reserves in an instant are the \'hare\' galaxies';
            imageUrl = "/Image/CharactersShow/Aisitan.png"; 
        } else if (index === 2) {
            textTitle = 'Himeko';
            textWord = 'An adventurous scientist who encountered the Astral Express as a young girl when it got stranded in her home world. Years later, Himeko finally repaired the train and began her journey to the stars, but she realized that this was only the beginning. On her trailblazing journey, she would need many more companion... And while they may have different destinations, they all gaze at the same starry sky.';
            textContent = 'Alright, crew! This world is the target of our next trailblazing expedition!';
            imageUrl = "/Image/CharactersShow/Jizi.png"; 
        } else if (index === 3) {
            textTitle = 'Kafka';
            textWord = 'On the Interastral Peace Corporation\'s wanted list, Kafka\' entry\r\nonly has two things\r\nher name,and a single sentence:\r\nLikes\r\ncollecting coats\r\nLittle is known about this Stellaron Hunter, other than that she is\r\none of Destin\'s Slave Elio\'s most trusted members.\r\nIn order to achieve Elio\'s envisioned future, Kafka gets to work.';
            textContent = 'You won\'t remember a thing except me.';
            imageUrl = "/Image/CharactersShow/Kfk.png"; 
        }
        textContent = textContent.replace(/\.\s/g, ".\n");
        title1.textContent = textTitle;
        title1.style.display = 'block';
        
        rightImage.src = imageUrl;
        text1.textContent = textContent;
        text1.style.display = 'block';
        text1T.textContent = textWord;
        text1T.style.display = 'block';
    });
});
const icons2 = document.querySelectorAll('.icon-b');
const rightImage2 = document.getElementById('right-image-chararcter2'); 
const text2 = document.getElementById('text2');
const text2T = document.getElementById('text2-2');
const title2 = document.getElementById('title2');

icons2.forEach((icon, index) => {
    icon.addEventListener('click', () => {
        let imageUrl = "";
        let textContent = "";
        let textTitle = "";
        let textWord = "";

        if (index === 0) {
            textTitle = 'Bronya';
            textWord = 'Heir to the Supreme Guardian of Belobog, she is the young and\r\ncapable commander of the Silvermane Guards.\r\nBronya received rigorous education from an early age, and\r\npossesses the grace and affinity as expected of an heir.\r\nHowever, after witnessing the abysmal conditions in the\r\nUnderworld, seeds of doubt began growing in Belobog\'s future\r\nleader\'s mind.\r\n\"Can all the training I\'ve received really help me lead the people\r\nto the lives they want ?\"';
            textContent = 'This place is always part of our homeland, even when it has been corroded by the Fragmentum. Silvermane Guards will never turn their backs on their home.';
            imageUrl = "/Image/CharactersShow/Buluoniya.png"; 
        } else if (index === 1) {
            textTitle = 'Gepard';
            textWord = 'The honorable and upstanding captain of the Silverman Guards\r\nwho bears the noble Landau family name.\r\nIn the frost-whipped city of Belobog, life can still go on in\r\nnormality..\r\nThis is in no small part thanks to Gepard and his Silvermane\r\nGuards who protect the peace of everyday life.';
            textContent = 'Loyalty isn\'t an inherent virtue of humans.As such, the recipient of that loyalty also needs to be worthy';
            imageUrl = "/Image/CharactersShow/jiepade.png"; 
        } else if (index === 2) {
            textTitle = 'Seele';
            textWord = 'A spirited and valiant member of Wildfire who grew up in the\r\nperilous Underworld of Belobog. She is accustomed to being on\r\nher own.\r\nThe protectors and the protected, the oppressors and the\r\noppressed.…. The world Seele grew up knowing was just a simple\r\ndichotomy...\r\nThat is, until \"that girl\" appeared.';
            textContent = 'To use our strength to create a fair society… Isn\'t that the obvious goal ? ';
            imageUrl = "/Image/CharactersShow/Xier.png"; 
        } else if (index === 3) {
            textTitle = 'Clara';
            textWord = 'A young girl raised by a robot, her perceptiveness and tenacity\r\nare far beyond her years.\r\nFor Clara, Svarog\'s logical calculations are law and infallible, \r\nThat is, until she realized that the results from \"calculations\" don\'t\r\nalways necessarily bring joy to everyone.\r\nThe once shy little gird then decided to cast aside her timidness.';
            textContent = 'Mr. Svarog…. is my family.';
            imageUrl = "/Image/CharactersShow/Kelala.png"; 
        } else if (index === 4) {
            textTitle = 'Sampo';
            textWord = 'A silver-tongued salesman, Where there is profit to be made, you\r\ncan be sure Sampo is nearby.\r\nSampo\'s unique knowledge makes it hard not to approach him\r\nfor help, but becoming his \"customer\" is not necessarily a good\r\nthing.\r\nAfter all, \"customers\" can quickly turn into \"commodities\" for the\r\nright price.';
            textContent = 'All sorts of business are welcome as long as you\'ve got the cash';
            imageUrl = "/Image/CharactersShow/Sangbo.png"; 
        }
        title2.textContent = textTitle;
        title2.style.display = 'block';
        text2.textContent = textContent;
        text2.style.display = 'block';
        text2T.textContent = textWord;
        text2T.style.display = 'block';
        rightImage2.src = imageUrl;
    });
});

const icons3 = document.querySelectorAll('.icon-luo');
const rightImage3 = document.getElementById('right-image-chararcter3');
const title3 = document.getElementById('title3');
const text3T = document.getElementById('text3-2');

icons3.forEach((icon, index) => {
    icon.addEventListener('click', () => {
        let imageUrl = "";
        let textContent = "";
        let textTitle = "";
        let textWord = "";
        if (index === 0) {
            textTitle = 'Jing Yuan';
            textWord = 'Although his appearance may be one of indolence, the Cloud\r\nKnight general who commands the Xianzhou Luofu is more\r\nmeticulous than seemingly meets the eye.\r\nHe does not consider saving a situation from the brink of disaster\r\nto be a show of wisdom, and is thus fastidious with routine\r\naffairs to avoid any potential problems.\r\nDue to his careful management, the Xianzhou have enjoyed many\r\nyears of peace, with Jing Yuan\'s seemingly lazy demeanor having\r\neared him the moniker of\r\n\"Dozing General.\" ';
            textContent = 'A truly masterful chess player has no brilliant moves.People clamor excitedly over displays of extreme cunning, forgetting to worry about the overall dangers of the situation.';
            imageUrl = "/Image/CharactersShow/Jingyuan.png"; 
        } else if (index === 1) {
            textWord = 'Dan Heng\'s true Vidyadhara form, revealed after accepting the\r\nresidual powers from the previous reincarnation of \"Imbibitor Lunae\".\r\n-\r\nUpon accepting the majestic horns atop his crown, he must\r\naccept all the merits and faults attributed to that person.\r\nHowever, he was never himself.';
            textTitle = 'Dan Heng Imbibitor Lunae';
            textContent = 'Even as we speak, farewells are happening throughout the universe.The grief that we share is real, but there\'s nothing special about it.';
            imageUrl = "/Image/CharactersShow/DanhengYinyue.png";
        }   else if (index === 2) {
            textTitle = 'Fu Xuan';
            textWord = 'The head of the Xianzhou Luofu\'s Divination Commission and\r\nconfident, no - nonsense sage.\r\nUsing her third eye and the Matrix of Prescience, Fu Xuan\r\ncalculates the Xianzhou\'s navigational route and predicts the\r\nfortune of future events. She firmly believes that everything she\r\ndoes is the \"best solution\" for the situation.\r\nFu Xuan is waiting for the general\'s promised \"abdication\". -\r\nHowever, that day still seems… very far away.';
            textContent = 'Knowledge exchanged with pain.';
            imageUrl = "/Image/CharactersShow/FuxuanC.png"; 
        } else if (index === 3) {
            textTitle = 'Yanqing';
            textWord = 'The spirited lieutenant of the Xianzhou Luofu, and also its most\r\nproficient swordsman.\r\nHe is born for swords and obsessed with them. Whenever a\r\nsword rests in his hand, none would dare to underestimate this\r\ngenius still in the early days of his youth.\r\nPerhaps the only thing capable of dulling his treasured blade\'s\r\nsharp edge is time.';
            textContent = 'I only called you \'teacher\' because I admire your skill in this area. Don\'t expect me to start taking it easy on you.';
            imageUrl = "/Image/CharactersShow/Yanqing.png"; 
        } else if (index === 4) {
            textTitle = 'Luocha';
            textWord = 'A handsome blond young man who carries a giant coffin on his\r\nback.\r\nAs an intergalactic merchant, he was unfortunately caught in the\r\nXianzhou Luofu\'s Stellaron crisis, \r\nAnd that is how he found his mastery of medicine to come in\r\nhandy.';
            textContent = 'This coffin isn\'t mine.I was merely entrusted to take the body back to the Luofu.';
            imageUrl = "/Image/CharactersShow/Luocha.png"; 
        }
        title3.textContent = textTitle;
        title3.style.display = 'block';
        text3.textContent = textContent;
        text3.style.display = 'block';
        text3T.textContent = textWord;
        text3T.style.display = 'block';
        rightImage3.src = imageUrl;
    });
});


