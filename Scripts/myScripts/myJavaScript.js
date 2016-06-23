function PageAjax() {
    alert(1);
    var json = GetJsonDate();
    alert(json.time);
    $.ajax({
        type: "GET",
        url: "myFirstPage.aspx",
       
        data: { time: JSON.stringify(GetJsonDate()) },
        datatype:"json",
        success: function (data) {
            alert(data);
        },
        error: function () {
            alert("error!!");
        }
    });

}

function AshxAjax() {
    $.ajax({
        type: "GET",
        url: "../Handler/Myhandler.ashx",
        data: JSON.stringify(GetJsonDate()), 
        datatype: "json",
        success: function (data) {
            alert(data);
        },
        error: function () {
            alert("error!!");
        }
    });

}

function WebServiceAjax() {
    $.ajax({
        type: "GET",
        url: "Myhandler.ashx",
        data: JSON.stringify(GetJsonDate()),
        datatype: "json",
        success: function (data) {
            alert(data);
        },
        error: function () {
            alert("error!!");
        }
    });

}

function GetJsonDate(){
    var now = new Date();
    var json = { "time": now.getHours() + ':' + now.getMinutes() + ':' + now.getSeconds() + ':' + now.getMilliseconds() };
    return json;
}