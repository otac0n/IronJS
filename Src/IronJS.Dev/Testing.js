﻿
var obj = {};
obj.a = "a-org";

with (obj) {
    var foo = function(x, y) {
        var myobj = {}
        myobj.a = "lol";
        with(myobj) {
            var a = 2;
            return a;
        }
    }

    var b;
    b = a;
    a = "a-next";
}

obj.b = b;
a_val = foo(1, 2);