import 'jquery'
import '../styles/1.css'
import '../styles/2.css'
import {getMessage} from './file2.js';

var result = getMessage();
$("#divtxt").html(result);