console.log("Js file")


function submitMethod() {
    console.log("Function Called")

    var uname = document.getElementById("uname")
    console.log(uname.value)

    var mail = document.getElementById("mail")
    console.log(mail.value)

    alert(uname.value + "|" + mail.value)
}