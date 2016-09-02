var db;
//database varsion setting
var version = 1.0;
//database name setting
var dbName = "tizendb";
//database display name setting
var dbDisplayName = "tizen_test_db";
//database size setting
var dbSize = 2 * 1024 * 1024;
//dataView(db);

function openDB() {
	if (window.openDatabase) {
		//openDatabase(name, version, displayname, estimatedsize, callback);
		db = openDatabase(dbName, version, dbDisplayName, dbSize);

		dropTable(db);
		createTable(db);
	} else {
		alert("Web SQL Database not supported in this browser");
	}
}


// create table
function createTable(db) {
	db.transaction(function(t) {
		t.executeSql("CREATE TABLE tizenTable (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, context TEXT, date DATETIME)",[]);
	});
}

//inserting data in table
function insertData(db, data) {
	db.transaction(function(e) {
		e.executeSql("INSERT INTO tizenTable(title, context, date) VALUES( ?, ?, ?)",[ data.title, data.context, data.date ],onSuccess, onError);
	});
}
function onSuccess(e) {}
function onError(e) {}

// drop table
function dropTable(db) {
	db.transaction(function(e) {
		e.executeSql("DROP TABLE tizenTable");
	});
}

//reads and displays values from the 'places' table
function dataView(db) {
	var html = document.getElementById("tbody01");
	html.innerHTML = "";

	db.transaction(function(t) {
		t.executeSql("SELECT * FROM tizenTable", [], function(tran, r) {
			// ddlHtml.innerHTML = "<option value='all'>all</option>";
			for (var i = 0; i < r.rows.length; i++) {
				var id = r.rows.item(i).id;
				var title = r.rows.item(i).title;
				var context = r.rows.item(i).context;
				var date = r.rows.item(i).date;

				//data list rendering
				if (html) {
					html.innerHTML += "<tr><td>" + id + "</td><td>" + title	+ "</td><td>" + context + "</td><td>" + date+ "</td></tr>";
				}
			}
		}, function(t, e) {
			alert("Error:" + e.message);
		});
	});
}

function saveBtnHandler() {
	var inputTitle = document.querySelector("#title"), 
		inputText = document.querySelector("#context"), 
		insertDate, 
		date = new Date(), 
		data;

	// get date for set current date into table
	insertDate = date.getFullYear() + "/" + (date.getMonth() + 1) + "/" + date.getDate();

	// set contexts of current creating memo to data object
	data = {
		"title" : inputTitle.value,
		"context" : inputText.value,
		"date" : insertDate
	};
	
	insertData(db, data);
	dataView(db);
}

function clickEventHandler() {
	document.querySelector("#save").addEventListener("click", saveBtnHandler);
}

function initDB() {
	openDB();
	clickEventHandler(dataView);
}

window.onload = function() {
	initDB();
};
