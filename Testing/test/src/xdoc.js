// XDoc load
assert(() => XDoc.load("return") == "testvalue65", "XDoc.load");

// include
XDoc.include("return");
assert(() => Buffer.get() == "testvalue65", "XDoc.include");
Buffer.clear();
assert(() => XDoc.load("parameters", {a: "AAA", b: "BBB"}) == "BBBAAA", "XDoc.load parameters");

// set
assert(() => XDoc.set("x", "", "", "testvalue32") == undefined, "XDoc.set");
assert(() => XDoc.load("set") == "testvalue32", "XDoc.set result");

// get
XDoc.load("get");
assert(() => XDoc.get("y", "", "") == "testvalue83", "XDoc.get");