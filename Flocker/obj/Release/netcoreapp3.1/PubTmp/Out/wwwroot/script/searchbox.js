


const searchBox = document.querySelector("#searchBox");
const searchResult = document.querySelector(".searchResult");
const mainContainer = document.querySelector(".main-container");

mainContainer.addEventListener("click", hideSearchResult);
searchBox.addEventListener("input", searchAjax)

searchBox.addEventListener("DOMFocusIn", revealSearchResult)

const searchErrorBox = document.querySelector(".searcherror");

const searchIcon = document.querySelector(".search-icon");

searchIcon.addEventListener("click", searchUsingClick);

searchBox.addEventListener("keypress", function (e) {
    if (e.key === 'Enter') {
        searchUsingClick();

    }




}
    )


function searchUsingClick() {

    productName = searchBox.value;

    if (productName.length <= 0) {

        searchErrorBox.style.visibility = "visible";
        searchErrorBox.style.opacity = "1";
        searchErrorBox.textContent = "Input required";

        setTimeout(() => {
            searchErrorBox.visibility = "hidden";
            searchErrorBox.style.opacity = "0";

        }, 2000)

    }
    else if (searchResult.childElementCount === 0) {
        searchErrorBox.style.visibility = "visible";
        searchErrorBox.style.opacity = "1";
        searchErrorBox.textContent = "No Results Found";

        setTimeout(() => {
            searchErrorBox.visibility = "hidden";
            searchErrorBox.style.opacity = "0";

        }, 2000)

    }
    else {

        const url = searchResult.firstElementChild.querySelector("a").attributes["href"].value;

        window.location.replace(url);
    }

}






function searchAjax(event) {


    const productName = searchBox.value;

   

    const ajax = new XMLHttpRequest();
    ajax.open("Post", "/Product/SearchResult", true);

    ajax.setRequestHeader("content-type", "application/json; charset=utf-8");
    ajax.responseType = "json";

    ajax.onload = function () {

        if (this.status === 200) {

            if (this.response.success === "true") {

                const data = this.response.data;

                let resultTemplate = "";

                for (let i = 0; i < data.length; i++) {


                    resultTemplate += `<li> <a href="/Product/detail/${data[i].ProductId}">
                        ${data[i].Name}<span>/ ${data[i].Category.Name} </span></a></li>`;
                }

            
                searchResult.innerHTML = resultTemplate;

            }

            else {
                
                searchResult.innerHTML = "";
            }

        }
    }



    const data = {
        productName : productName
    }

    ajax.send(JSON.stringify(data));

}

function revealSearchResult() {
    searchResult.style.display = "block";
}
function hideSearchResult() {

    searchResult.style.display = "none";
}