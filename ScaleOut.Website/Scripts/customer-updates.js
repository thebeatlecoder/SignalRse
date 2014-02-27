$(function () {  
    var customerUpdate = $.connection.customerUpdateHub;
    
    customerUpdate.client.subscribeTo = function (customerSurnameUpdated) {
        var surnameSelector = '#surname-' + customerSurnameUpdated.Id;
        $(surnameSelector).html(customerSurnameUpdated.NewSurname);
    };

    $.connection.hub.start()
        .done(outputSuccessMessage)
        .fail(outputErrorMessage);
});

function outputSuccessMessage() {
    console.log('Successfully connected to the Customer Update hub.');
}

function outputErrorMessage() {
    console.log('An error occurred while connecting to the Customer Update hub: ' + error);
}