// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const tmpConst = {
    filepicked : "filepicked",
    filename : "filename",
    fileset: "fileset",
    inputgroup: "input-group"
};

function getidstr(str) {
    return '#' + str;
};

function getclassstr(str) {
    return '.' + str;
};

function getfileset() {

    return $(getidstr(tmpConst.fileset));
};

function gettempinputfile() {

    return $("template#input-file")[0].content.cloneNode(true);
};

function getpickedfileName(inputfile) {

    var fileName = inputfile.val().split('\\').pop();

    return fileName;
}

function refreshinputfile(inputfile) {

    inputfile.parent().addClass(tmpConst.filepicked);

    inputfile.parent().find(getclassstr(tmpConst.filename)).text(getpickedfileName(inputfile));
}

function islast(inputfile) {

    return inputfile.parents("ul").children().length
           === getparentli(inputfile).index() + 1;
};

function getparentli(child) {

    return child.parents("li");
}

$(document).ready(function () {

    getfileset().append(gettempinputfile());

    getfileset().on('change', ':file', function () {

        if ($(this).val()) {

            refreshinputfile($(this));
         
            if (islast($(this))) {

                getfileset().append(gettempinputfile());
            }
        }
    });

    getfileset().on('click', ':button', function () {

        if (getparentli($(this)).find("input:file").val()) {

            getparentli($(this)).remove();
        }
    });
});


