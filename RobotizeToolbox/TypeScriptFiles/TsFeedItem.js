var TsFeedItem = /** @class */ (function () {
    function TsFeedItem(_xpath) {
        this._xpath = _xpath;
    }
    TsFeedItem.prototype.isElementOutViewport = function (element) {
        //let element = document.evaluate("//div", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
        var rect = element.getBoundingClientRect();
        console.log(rect.top);
        console.log(rect.bottom);
        console.log((document.documentElement.clientHeight));
        var hight = (window.innerHeight || document.documentElement.clientHeight);
        var width = (window.innerWidth || document.documentElement.clientWidth);
        var res = (rect.top >= 0 &&
            rect.left >= 0 &&
            (rect.bottom) <= hight &&
            rect.right <= width);
        var diff = 0;
        if (res)
            return res;
        else if (res == false && (rect.top < 0 && rect.bottom > hight))
            return true;
        else if (rect.top < 0) {
            diff = rect.bottom + rect.top;
            console.log(diff);
            console.log("Top");
        }
        else if (rect.bottom > hight) {
            diff = hight - rect.top;
            console.log(diff);
            console.log("Bottom");
        }
        console.log(hight / 2.5);
        return diff >= hight / 2.5;
    };
    TsFeedItem.prototype.getElementsByXPath = function (xpath) {
        return document.evaluate(xpath, document, null, XPathResult.ANY_TYPE, null);
    };
    TsFeedItem.prototype.printListItems = function () {
        var result = this.getElementsByXPath("//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span");
        var buttons = [];
        var node = result.iterateNext();
        while (node) {
            // const input = node.TEXT_NODE as HTMLElement;
            // TODO: this need to be fixed for getting a text value from a node.
            buttons.push(node.TEXT_NODE);
            node = result.iterateNext();
        }
        buttons.forEach(function (item) {
            console.log("public Button Button" + item.split(" ").join("") + " => new Button(Driver, By.XPath($\"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()=" + item.split(" ").join("") + "'\"));");
        });
        buttons.forEach(function (item) {
            console.log("< data name = \"" + item.split(" ").join("") + "\" xml: space = \"preserve\" >< value >" + item + "</ value ></ data >");
        });
    };
    return TsFeedItem;
}());
//# sourceMappingURL=TsFeedItem.js.map