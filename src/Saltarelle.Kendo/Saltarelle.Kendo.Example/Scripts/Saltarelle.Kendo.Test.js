(function() {
	'use strict';
	var $asm = {};
	global.Saltarelle = global.Saltarelle || {};
	global.Saltarelle.Kendo = global.Saltarelle.Kendo || {};
	global.Saltarelle.Kendo.Test = global.Saltarelle.Kendo.Test || {};
	ss.initAssembly($asm, 'Saltarelle.Kendo.Test');
	////////////////////////////////////////////////////////////////////////////////
	// Saltarelle.Kendo.Test.Window
	var $Saltarelle_Kendo_Test_Window = function() {
	};
	$Saltarelle_Kendo_Test_Window.__typeName = 'Saltarelle.Kendo.Test.Window';
	$Saltarelle_Kendo_Test_Window.get_jQueryWindow = function() {
		var obj = $('#Window');
		if (obj.length === 0) {
			$('body').append($('<div>').attr('id', 'Window'));
		}
		return $('#Window');
	};
	$Saltarelle_Kendo_Test_Window.start = function() {
		$('#SimpleWindow').on('click', function(eve) {
			$Saltarelle_Kendo_Test_Window.$openSimpleWindow();
		});
		$('#AjaxWindow').on('click', function(eve1) {
			$Saltarelle_Kendo_Test_Window.$openAjaxWindow();
		});
		$Saltarelle_Kendo_Test_Window.$apiHandler();
	};
	$Saltarelle_Kendo_Test_Window.$openAjaxWindow = function() {
		var windowElement = $Saltarelle_Kendo_Test_Window.get_jQueryWindow().kendoWindow({ actions: ['refresh', 'close'], content: '/Window/AjaxContent/', draggable: true, height: '200px', iframe: false, modal: true, title: 'ajax Window', width: '500px' });
		windowElement.data('kendoWindow').center().open();
	};
	$Saltarelle_Kendo_Test_Window.$openSimpleWindow = function() {
		var windowElement = $Saltarelle_Kendo_Test_Window.get_jQueryWindow().kendoWindow({ actions: ['refresh', 'close', 'restore'], content: 'Simple Window', draggable: true, height: '400px', iframe: false, modal: false, title: 'simple Window', width: '600px' });
		windowElement.data('kendoWindow').center().open();
	};
	$Saltarelle_Kendo_Test_Window.$apiHandler = function() {
		$('#maximizeWindow').on('click', function(eve) {
			$Saltarelle_Kendo_Test_Window.$doAction(function(c) {
				c.restore();
			});
		});
		$('#minimizeWindow').on('click', function(eve1) {
			$Saltarelle_Kendo_Test_Window.$doAction(function(c1) {
				c1.minimize();
			});
		});
		$('#closeWindow').on('click', function(eve2) {
			$Saltarelle_Kendo_Test_Window.$doAction(function(c2) {
				c2.close();
			});
		});
		$('#centerWindow').on('click', function(eve3) {
			$Saltarelle_Kendo_Test_Window.$doAction(function(c3) {
				c3.center();
			});
		});
	};
	$Saltarelle_Kendo_Test_Window.$doAction = function(act) {
		var window = $Saltarelle_Kendo_Test_Window.get_jQueryWindow().data('kendoWindow');
		if (!ss.isNullOrUndefined(window)) {
			act(window);
		}
	};
	global.Saltarelle.Kendo.Test.Window = $Saltarelle_Kendo_Test_Window;
	ss.initClass($Saltarelle_Kendo_Test_Window, $asm, {});
})();
