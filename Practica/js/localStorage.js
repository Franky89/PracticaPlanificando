
	
	// por defecto almacenamiento local
	var storage = localStorage;
	
	function guardar() {
	 	var clave = "f_"+localStorage.length;
	 	var valor = '{"nombre":"' + document.getElementById('textName').value + '","latitud":"' + document.getElementById('Latitud').value + '","longitud":"' + document.getElementById('Longitud').value +'"}';
		 if (clave == '' || valor == '') {
	 		alert('Por favor, rellena clave y valor');
	 		return;
	 	}
	 	storage.setItem(clave, valor);
	 	limpiar();
	 	refrescaTodo();
	}
	
	function limpiar() {
		document.getElementById('textName').value = '';
	 	document.getElementById('Latitud').value = '';
		document.getElementById('Longitud').value = '';
	}
	
	function refrescaTodo() {
		refrescar(localStorage, document.getElementById('almacenamientoLocal'));
		refrescar(sessionStorage, document.getElementById('almacenamientoSesion'));
	}
	
	function refrescar(storage, area) {
		area.innerHTML = '';
		for (var i=0; i<storage.length; i++) {
			var clave = storage.key(i);
			var valor = storage.getItem(clave);
			//var obj = JSON.parse(valor);
			
			area.innerHTML += (clave + '=' + valor + '\n');
		}
		
	}
	
	function eliminar() {
		var clave = document.getElementById('clave').value;
	 	if (clave == '') {
	 		alert('Por favor, rellena clave');
	 		return;
	 	}
	 	storage.removeItem(clave);
	 	limpiar();
	 	refrescaTodo();
	}
		
	function compruebaCompatibilidad() {
		if (window.sessionStorage && window.localStorage) {			anadirMensaje('Tu navegador acepta almacenamiento local'); 
		} else {			anadirMensaje('Lo siento, pero tu navegador no acepta almacenamiento local');		}	}
	
	function anadirMensaje(mensaje) {
		var contenedorMensajes = document.getElementById('mensajes');
		contenedorMensajes.innerHTML = mensaje;
		setTimeout(function () {
			contenedorMensajes.innerHTML='';
		}, 3000);
	}
	
	// función que será invocada cuando se produzca un almacenamiento 
	function eventoAlmacenamiento(e) {	
		refrescaTodo();
	}
	
	// añadimos el listener que dispará la función cuando se produzca el evento de almacenamiento
	window.addEventListener("storage", eventoAlmacenamiento, false);

