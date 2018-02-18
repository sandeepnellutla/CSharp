import {file1obj1,file1obj2} from './file1.js';

export var getMessage= function(){    
    var result = file1obj1+' '+file1obj2;
    return result;
}