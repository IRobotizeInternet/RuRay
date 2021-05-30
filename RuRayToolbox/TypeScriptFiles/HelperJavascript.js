//function getElementsByXPath(xpath)
//{
//    var result = document.evaluate(xpath, document, null, XPathResult.ANY_TYPE, null);
//    return result;
//}

//function GetListItems()
//{
//    let result = getElementsByXPath("//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span");
//    var buttons = [];
//    var res = [];
//    while (node = result.iterateNext())
//    {
//        buttons.push(node.innerText);
//    }

//    buttons.forEach(function(item)
//    {
//        console.log(`public Button Button${ item.split(" ").join("")} => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()=${item.split(" ").join("")}'"));`); 
//    });

//buttons.forEach(function(item)
//    {
//    console.log(`< data name = "${item.split(" ").join("")}" xml: space = "preserve" >< value >${ item}</ value ></ data >`);
//});
//}

//GetListItems();


//for (let i = 0; i < elemts.length; i++)
//{
//    let t = elemts[i].innerText.split(' ').join('')
//    let str = `public EventTriggerButton<Page${ t}> Page${ t} => new EventTriggerButton<Page${t}> (Driver, By.XPath($"{BaseXPath}//span[text()='{ResHomePageHeader.${t}}']"));`
//    console.log(str);
//}