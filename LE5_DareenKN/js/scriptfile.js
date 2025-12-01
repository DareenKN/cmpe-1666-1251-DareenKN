// CMPE 2000 - Fall2025 Lab Exam5 

//Global Variable to store cost of selected food item.
let foodCost = 15;
let birdArray = ["bird1.jfif", "eagle.jpg", "flamingo.jpeg", "kingfisher.jpg", "parot.jpg"]
let count = 0;
let timerID = 0;

window.onload = () => {
    document.querySelector("form").onsubmit = validate

    document.querySelectorAll("[name=food]").forEach((element)=>{
        element.onchange = (event) => {
            switch(event.target.value) {
                case "burger":
                    foodCost = 5
                    break
                case "pizza":
                    foodCost = 9
                    break
                case "sandwich":
                    foodCost = 6
                    break
                default: break
            }
            console.log ("foodCost: " + foodCost)
            calculateTotalCost()
        }
    })

    document.querySelector("#foodItemCount").onchange = calculateTotalCost

    document.querySelector("#firstBird").onclick = ()=>{        
        document.querySelector("#birdPic").setAttribute("src", `images/${birdArray[0]}`)
        clearInterval(timerID)
    }

    document.querySelector("#changeBird").onclick = ()=>{
        // Adjust timer
        clearInterval(timerID)
        
        timerID = setInterval(birdSlideShow, 1000)
    }
}

function birdSlideShow(){
    count = (count + 1) % birdArray.length
    document.querySelector("#birdPic").setAttribute("src", `images/${birdArray[count]}`)
}

function calculateTotalCost() {
    let qty = parseInt(document.querySelector("#foodItemCount").value)
    if(!qty) return
    document.querySelector("#totalCost").value = foodCost *  qty
}

function validate() {
    let namelength = document.querySelector("#uname").value.trim().length
    if(namelength <= 0){
        alert("Name must not be empty")
        return false
    }

    if(!document.querySelector("[name='food']:checked")){
        alert("One food needs to be checked")
        return false
    }

    let number = parseInt(document.querySelector("#foodItemCount").value)
    if(!number){
        alert("Food item qty needs to be a valid number")
        return false
    }

    return true
}
