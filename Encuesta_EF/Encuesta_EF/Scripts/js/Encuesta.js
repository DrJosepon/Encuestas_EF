// Defining angularjs module
var app = angular.module('encuestaModulo', []);

// Defining angularjs Controller and injecting EncuestasServicio
app.controller('encuestaCtrl', function ($scope, $http, EncuestasServicio) {
    $scope.encuestasDatos = null;
    // Fetching records from the factory created at the bottom of the script file
    EncuestasServicio.GetEncuestas().then(function (d) {
        $scope.encuestasDatos = d.data; // Success
    }, function () {
        alert('Error Occured !!!'); // Failed
    });

    $scope.preguntasDatos = null;
    // Fetching records from the factory created at the bottom of the script file
    EncuestasServicio.GetPreguntas().then(function (d) {
        $scope.preguntasDatos = d.data; // Success
    }, function () {
        alert('Error Occured !!!'); // Failed
    });

    $scope.alternativasDatos = null;
    // Fetching records from the factory created at the bottom of the script file
    EncuestasServicio.GetAlternativas().then(function (d) {
        $scope.alternativasDatos = d.data; // Success
    }, function () {
        alert('Error Occured !!!'); // Failed
    });

    $scope.respuestasDatos = null;
    // Fetching records from the factory created at the bottom of the script file
    EncuestasServicio.GetAlternativas().then(function (d) {
        $scope.respuestasDatos = d.data; // Success
    }, function () {
        alert('Error Occured !!!'); // Failed
    });

    $scope.areas = [
           { Cod_Area: 1, Descripcion: "Asesoría Legal" },
           { Cod_Area: 2, Descripcion: "TIC" },
           { Cod_Area: 3, Descripcion: "GCH" },
           { Cod_Area: 4, Descripcion: "Logistica" },
    ];

    $scope.Respuesta = {
        CodRespuesta: '',
        Cod_Alternativa: '',
        Cod_Area: '',
    };

    $scope.Respuestas = [];
    
    $scope.anadir = function (data, area) {
        debugger;
        var obj = new Object();
        obj.Cod_Area = area;
        obj.Cod_Alternativa = data.Cod_Alternativa;
        $scope.Respuestas.push(obj);
    }

    //Add New Item
    $scope.guardar = function () {
        if ($scope.Encuesta.Nombres != "" &&
       $scope.Encuesta.ApellidoPaterno != "" && $scope.Encuesta.ApellidoMaterno != "" && $scope.Encuesta.Encuesta != "" && $scope.Encuesta.IdSegTipoEncuesta != "") {
            $http({
                method: 'POST',
                url: '../api/Seg_Encuesta',
                data: $scope.Encuesta
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                $scope.encuestasDatos.push(response.data);
                $scope.limpiar();
                alert("Encuesta Agregado");
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
                alert("Error : " + response.data.ExceptionMessage);
            });
        }
        else {
            alert('Llene todos los campos.');
        }
    };

    // Update product details
    $scope.modificar = function () {
        if ($scope.Encuesta.Descripcion != "" && $scope.Encuesta.Estado != "") {
            $http({
                method: 'PUT',
                url: '../api/Seg_Encuesta/' + $scope.Encuesta.IdGprTipoEstadoAve,
                data: $scope.Encuesta
            }).then(function successCallback(response) {
                debugger;
                $scope.encuestasDatos = response.data;
                $scope.limpiar();
                alert("Encuesta Updated Successfully !!!");
            }, function errorCallback(response) {
                alert("Error : " + response.data.ExceptionMessage);
            });
        }
        else {
            alert('Please Enter All the Values !!');
        }
    };
});

// Here I have created a factory which is a popular way to create and configure services.
// You may also create the factories in another script file which is best practice.

app.factory('EncuestasServicio', function ($http) {
    var fac = {};
    fac.GetEncuestas = function () {
        return $http.get('../api/En_Encuesta');
    };
    fac.GetPreguntas = function () {
        return $http.get('../api/En_Pregunta');
    };
    fac.GetAlternativas = function () {
        return $http.get('../api/En_Alternativa');
    };
    fac.GetRespuestas = function () {
        return $http.get('../api/En_Respuesta');
    };
    return fac;
});