const questionMark = document.querySelector(".question-mark");
const popup = document.getElementById("popup");


questionMark.addEventListener("click", function (event) {

    popup.style.display = (popup.style.display === "none" || popup.style.display === "") ? "block" : "none";


    event.stopPropagation();
});


document.addEventListener("click", function (event) {

    if (popup.style.display !== "none") {
        popup.style.display = "none";
    }
});