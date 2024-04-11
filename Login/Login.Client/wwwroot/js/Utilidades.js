function testNetStatic() {
    DotNet.invokeMethodAsync("JBSuite.Client", "IncrementCountStatic")
        .then(result => {
            console.log('Conteo desde JS: ' + result);
        })
}

function testNetInstancia(dotNetHelper) {
    dotNetHelper.invokeMethodAsync("IncrementCount");
}

function timerInactivo(dotNetHelper) {
    var timer;
    document.onmousemove = resetTimer;
    document.onkeypress = resetTimer;

    function resetTimer() {
        clearTimeout(timer);
        timer = setTimeout(logout, 60 * 1000 * 10) //10 minutos

    }

    function logout() {
        dotNetHelper.invokeMethodAsync("Logout");
    }
}


function OnCloseWindow() {
    window.close();
}


function OnImprimirPagina(pageName) {
    // Ocultar otros elementos que no deseas imprimir
    document.querySelector('.page-container').style.display = 'none'; // Oculta otros contenidos

    // Imprimir solo el contenido del div con id "pagina"
    var contenidoPagina = document.getElementById('pagina').innerHTML;
    var contenidoOriginal = document.body.innerHTML;

    document.title = pageName;

    document.body.innerHTML = contenidoPagina;

    window.print();

    // Restaurar el contenido original y mostrar nuevamente los elementos ocultos
    document.body.innerHTML = contenidoOriginal;
    document.querySelector('.page-container').style.display = 'block'; // Muestra nuevamente los otros contenidos

    setTimeout(function () {
        window.close(); // Intenta cerrar la ventana actual
    }, 1000); // Espera 1 segundo (puedes ajustar este tiempo)
}

function BlazorDownloadFile(filename, content) {
    // thanks to Geral Barre : https://www.meziantou.net/generating-and-downloading-a-file-in-a-blazor-webassembly-application.htm 

    // Create the URL
    const file = new File([content], filename, { type: "application/octet-stream" });
    const exportUrl = URL.createObjectURL(file);

    // Create the <a> element and click on it
    const a = document.createElement("a");
    document.body.appendChild(a);
    a.href = exportUrl;
    a.download = filename;
    a.target = "_self";
    a.click();

    // We don't need to keep the object url, let's release the memory
    // On Safari it seems you need to comment this line... (please let me know if you know why)
    URL.revokeObjectURL(exportUrl);
}

function BlazorOpenFile(filename, content) {

    // Create the <a> element and click on it
    const a = document.createElement("a");
    document.body.appendChild(a);
    a.href = filename;
    a.download = filename;
    a.target = "_self";
    a.click();
}


function eliminarHrefs() {

    var miDiv = document.getElementById('divSidebarMenuClickHandler');

    if (miDiv) {

        // Obtener todos los elementos <a> dentro de miDiv con las clases específicas
        var enlaces = miDiv.querySelectorAll('a.navbar-brand.d-flex.align-items-center');

        for (var i = 0; i < enlaces.length; i++) {
            enlaces[i].removeAttribute('href');
        }
    }
}