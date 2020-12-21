

$(document).ready(function () {
 

  

    $('#tblPerson').DataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "orderMulti": false, // for disable multi column order
        "dom": '<"top"i>rt<"bottom"lp><"clear">',
        "ajax": {
            "url": "http://localhost:65380/api/PruebaCovit/",
            "type": "POST",
            "datatype": "json",
            "headers": {
                "Content-Type": "application/x-www-form-urlencoded"
            },
        },
        "columns": [
            { "data": "country", "name": "Country", "autoWidth": true },
            { "data": "countryCode", "name": "CountryCode", "autoWidth": true },
            { "data": "slug", "name": "Slug", "autoWidth": true },
            {
                "bSortable": false,
                "render": function (data, type, row) {
                   
                    var inner = '<div class="btn-group">' +
                        '<button type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
                        'Accion' +
                        '</button>' +
                        '<div class="dropdown-menu">' +
                        '<a class="dropdown-item btn btn-default editButton" data-id="' + row.Identificacion + '" data-toggle="modal" data-target="#myModal" href="#" >Editar </a>' +
                        '<a class="dropdown-item btn btn-default" data-id="' + row.Identificacion + '" href="#" >Borrar </a>' +
                        '</div>' +
                        '</div>';

                    return inner;

                }
            }
        ]


    });
    oTable = $('#tblPerson').DataTable();
    $('#btnSearch').click(function () {
        //Apply search for Employee Name // DataTable column index 0
        oTable.columns(2).search($('#txtBuscar').val());
        //hit search on server
        oTable.draw();
    });

    $("#btnAgregar").on('click', function () {
        $("#btnAgregar").show();
        $("#btnUpdate").hide();

        var persona = {};
        persona.Identificacion = $("#txtIdentificacion").val();
        persona.Name = $("#txtName").val();
        var datos = JSON.stringify(persona);
        $.ajax({
            type: "POST",
            url: "/Persona/createPerson", //Direccion del servicio web segido de /Nombre del metodo a llamar
            data: '{persona: ' + JSON.stringify(persona) + '}', //Esto se utiliza si deseamos pasar algun paramentro al metodo del servicio web ejm: {'indentificacion':'1234'}
            contentType: "application/json; charset=utf-8",
            dataType: "json", //Esto quiere decir que los datos nos llegaran como un objeto json
            success: function (response) { //Aca se recibe la respuesta del metodo llamado
                if (response.Result = "Ok") {
                    alert("Registros Guardados");
                    $("#txtIdentificacion").val('');
                    $("#txtName").val('');
                    oTable.ajax.reload();;

                }
            }

        })
    })

    $("#btnUpdate").on('click', function () {


        var persona = {};
        persona.Identificacion = $("#txtIdentificacion").val();
        persona.Name = $("#txtName").val();
        var datos = JSON.stringify(persona);
        $.ajax({
            type: "POST",
            url: "/Persona/UpdatePerson", //Direccion del servicio web segido de /Nombre del metodo a llamar
            data: '{persona: ' + JSON.stringify(persona) + '}', //Esto se utiliza si deseamos pasar algun paramentro al metodo del servicio web ejm: {'indentificacion':'1234'}
            contentType: "application/json; charset=utf-8",
            dataType: "json", //Esto quiere decir que los datos nos llegaran como un objeto json
            success: function (response) { //Aca se recibe la respuesta del metodo llamado
                if (response.Result = "Ok") {
                    alert("Registros Guardados");
                    $("#txtIdentificacion").val('');
                    $("#txtName").val('');
                    oTable.ajax.reload();;

                }
            }

        })
    })

});


$(document).on("click", ".editButton", function () {
    $('#myModal').focus();
    var id = $(this).attr("data-id");
    console.log(id);
    if (id != 'undefined' && id != 0) {
        $("#btnUpdate").attr("edit-id", id); // Here I am Passing the ID of that edit id to update that specific data  
        //alert(id);  //getting the row id
        $("#btnAgregar").hide();
        $("#btnUpdate").show();

    } else {
        $("#btnAgregar").show();
        $("#btnUpdate").hide();
    }


    $.ajax({
        type: "Post",
        contentType: "application/json; charset=utf-8",
        url: "/Persona/GetPersonsId", // Default.aspx is the Page and EditData() is my WebMethod  
        data: "{id:" + id + "}", // Showing the Details of Record of Specific ID  
        dataType: "json",
        success: function (data) {


            //console.log(v.Fname);    
            $("#txtIdentificacion").val(data.Identificacion);
            $("#txtName").val(data.Name);
            //$("#Dob1").val(data.d.Records[0]._hab);
            //$("#MaritalStatus1").val(data.d.Records[0]._vlrm);
            //$("#Hobbies1").val(data.d.Records[0]._vltapt);
            //$("#TelephoneNo1").val(data.d.Records[0]._vlrplk);
            //$("#MobileNo1").val(data.d.Records[0]._vltotal);
            //$("#ResidentialAddress1").val(data.d.Records[0]._observacion);
            //$("#PinCode1").val(data.d.Records[0]._cc);
            //$("#State1").val(data.d.Records[0]._nombre);
            //$("#Nationality1").val(data.d.Records[0]._cel);
            //$("#Doj1").val(data.d.Records[0]._dir);
            //$("#dropEstado").val(data.d.Records[0]._estado);
        },
        error: function () {
            alert("Error while retrieving data of :" + id);
        }
    });
});

//$(function () {
//$("#btnAgregar").on('click', function () {

//    var persona = {};
//    persona.Identificacion = $("#txtIdentificacion").val();
//    persona.Name = $("#txtName").val();
//    var datos = JSON.stringify(persona);
//    $.ajax({
//        type: "POST",
//        url: "/Persona/createPerson", //Direccion del servicio web segido de /Nombre del metodo a llamar
//        data: "{persona:" + persona + "}", //Esto se utiliza si deseamos pasar algun paramentro al metodo del servicio web ejm: {'indentificacion':'1234'}
//        contentType: "application/json; charset=utf-8",
//        dataType: "json", //Esto quiere decir que los datos nos llegaran como un objeto json
//        success: function (response) { //Aca se recibe la respuesta del metodo llamado
//            if (response.Result = "Ok") {
//                alert("Registros Guardados");



//            }
//        }

//    })
//})
//});