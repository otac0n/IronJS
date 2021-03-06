// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S15.6.2.1_A3;
 * @section: 15.6.2.1;
 * @assertion: The [[Value]] property of the newly constructed object 
 * is set to ToBoolean(value);
 * @description: Checking value of the newly created object;
 */

// CHECK#1
var x1 = new Boolean(1);
if (x1.valueOf() !== true) {
  $ERROR('#1: var x1 = new Boolean(1); x1.valueOf() === true');
}

//CHECK#2
var x2 = new Boolean();
if (x2.valueOf() !== false) {
  $ERROR('#2: var x2 = new Boolean(); x2.valueOf() === false');
}

//CHECK#3
var x2 = new Boolean(0);
if (x2.valueOf() !== false) {
  $ERROR('#3: var x2 = new Boolean(0); x2.valueOf() === false');
}

//CHECK#4
var x2 = new Boolean(new Object());
if (x2.valueOf() !== true) {
  $ERROR('#4: var x2 = new Boolean(new Object()); x2.valueOf() === true');
}
