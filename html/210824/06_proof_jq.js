$(
function()
{
    let BigCount = prompt("대수의 법칙을 증멸할 수는?", 1000)
    let arr=[0,0,0,0,0,0]
    
    for(let i=0; i<BigCount; i++)
    {
        let random = Math.floor(Math.random()*6);
        arr[random]++
    }

    for(let i = 0; i<arr.length; i++)
    {
        $('h1.num'+(i+1)).innerText(arr[i])
    }

    let max = 0 
    let maxIndex = 0 

    for(let i=1; i<=6; i++)
    {
        let value = $('h1.num'+i).innerText
        if(max<value)
        {
            max = value
            maxIndex = i
        }
        value = (value/BigCount)*100
        $('h2.num'+i).Text(parseFloat(value).toFixed(2)+'%')

    }

    //색깔칠하기
    $('h1.num'+maxIndex).addClass('max')
    $('h2.num'+maxIndex).addClass('max')
}
)
