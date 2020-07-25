

const navButtons = document.querySelectorAll(".carousel__indicator");
const imgContainer = document.querySelector(".carousel__images");

for (let i = 0; i < navButtons.length; i++) {


    navButtons[i].addEventListener("click", function (event) {

        const imgUrl = event.target.attributes["src"].value;
        imgContainer.setAttribute("src", imgUrl);

    })
}