
while(true)
{
    let number=prompt("Guess a number:");
    number=Number(number);
    const randomNumber=Math.ceil(Math.random()*10);
    if(number===randomNumber)
    {
        alert('You win');
        break;
    }
    else
    {
        console.log("You guessed ",number,"but the number was ",randomNumber);
    }
}
