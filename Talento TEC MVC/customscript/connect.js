    $(document).ready(function () {
        $.ajax({
            url: "http://talentotec-api.azurewebsites.net/api/Careers"
        }).then(function (data) {
            console.log(data);
            //$('.greeting-id').append(data.id);
            //$('.greeting-content').append(data.content);
        });
    });