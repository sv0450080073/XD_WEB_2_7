// Generated by build/tasks/qunit_fixture.js
QUnit.config.fixture = "<p id=\"firstp\">See <a id=\"simon1\" href=\"http://simon.incutio.com/archive/2003/03/25/#getElementsBySelector\" rel=\"bookmark\">this blog entry</a> for more information.</p>\n<p id=\"ap\">\n\tHere are some links in a normal paragraph: <a id=\"google\" href=\"http://www.google.com/\" title=\"Google!\">Google</a>,\n\t<a id=\"groups\" href=\"http://groups.google.com/\" class=\"GROUPS\">Google Groups (Link)</a>.\n\tThis link has <code><a href=\"http://smin\" id=\"anchor1\">class=\"blog\"</a></code>:\n\t<a href=\"http://diveintomark.org/\" class=\"blog\" hreflang=\"en\" id=\"mark\">diveintomark</a>\n\n</p>\n<div id=\"foo\">\n\t<p id=\"sndp\">Everything inside the red border is inside a div with <code>id=\"foo\"</code>.</p>\n\t<p lang=\"en\" id=\"en\">This is a normal link: <a id=\"yahoo\" href=\"http://www.yahoo.com/\" class=\"blogTest\">Yahoo</a></p>\n\t<p id=\"sap\">This link has <code><a href=\"#2\" id=\"anchor2\">class=\"blog\"</a></code>: <a href=\"http://simon.incutio.com/\" class=\"blog link\" id=\"simon\">Simon Willison's Weblog</a></p>\n\n</div>\n<div id=\"nothiddendiv\" style=\"height:1px;background:white;\" class=\"nothiddendiv\">\n\t<div id=\"nothiddendivchild\"></div>\n</div>\n<span id=\"name+value\"></span>\n<p id=\"first\">Try them out:</p>\n<ul id=\"firstUL\"></ul>\n<ol id=\"empty\"></ol>\n<form id=\"form\" action=\"formaction\">\n\t<label for=\"action\" id=\"label-for\">Action:</label>\n\t<input type=\"text\" name=\"action\" value=\"Test\" id=\"text1\" maxlength=\"30\"/>\n\t<input type=\"text\" name=\"text2\" value=\"Test\" id=\"text2\" disabled=\"disabled\"/>\n\t<input type=\"radio\" name=\"radio1\" id=\"radio1\" value=\"on\"/>\n\n\t<input type=\"radio\" name=\"radio2\" id=\"radio2\" checked=\"checked\"/>\n\t<input type=\"checkbox\" name=\"check\" id=\"check1\" checked=\"checked\"/>\n\t<input type=\"checkbox\" id=\"check2\" value=\"on\"/>\n\n\t<input type=\"hidden\" name=\"hidden\" id=\"hidden1\"/>\n\t<input type=\"text\" style=\"display:none;\" name=\"foo[bar]\" id=\"hidden2\"/>\n\n\t<input type=\"text\" id=\"name\" name=\"name\" value=\"name\" />\n\t<input type=\"search\" id=\"search\" name=\"search\" value=\"search\" />\n\n\t<button id=\"button\" name=\"button\" type=\"button\">Button</button>\n\n\t<textarea id=\"area1\" maxlength=\"30\">foobar</textarea>\n\n\t<select name=\"select1\" id=\"select1\">\n\t\t<option id=\"option1a\" class=\"emptyopt\" value=\"\">Nothing</option>\n\t\t<option id=\"option1b\" value=\"1\">1</option>\n\t\t<option id=\"option1c\" value=\"2\">2</option>\n\t\t<option id=\"option1d\" value=\"3\">3</option>\n\t</select>\n\t<select name=\"select2\" id=\"select2\">\n\t\t<option id=\"option2a\" class=\"emptyopt\" value=\"\">Nothing</option>\n\t\t<option id=\"option2b\" value=\"1\">1</option>\n\t\t<option id=\"option2c\" value=\"2\">2</option>\n\t\t<option id=\"option2d\" selected=\"selected\" value=\"3\">3</option>\n\t</select>\n\t<select name=\"select3\" id=\"select3\" multiple=\"multiple\">\n\t\t<option id=\"option3a\" class=\"emptyopt\" value=\"\">Nothing</option>\n\t\t<option id=\"option3b\" selected=\"selected\" value=\"1\">1</option>\n\t\t<option id=\"option3c\" selected=\"selected\" value=\"2\">2</option>\n\t\t<option id=\"option3d\" value=\"3\">3</option>\n\t\t<option id=\"option3e\">no value</option>\n\t</select>\n\t<select name=\"select4\" id=\"select4\" multiple=\"multiple\">\n\t\t<optgroup disabled=\"disabled\">\n\t\t\t<option id=\"option4a\" class=\"emptyopt\" value=\"\">Nothing</option>\n\t\t\t<option id=\"option4b\" disabled=\"disabled\" selected=\"selected\" value=\"1\">1</option>\n\t\t\t<option id=\"option4c\" selected=\"selected\" value=\"2\">2</option>\n\t\t</optgroup>\n\t\t<option selected=\"selected\" disabled=\"disabled\" id=\"option4d\" value=\"3\">3</option>\n\t\t<option id=\"option4e\">no value</option>\n\t</select>\n\t<select name=\"select5\" id=\"select5\">\n\t\t<option id=\"option5a\" value=\"3\">1</option>\n\t\t<option id=\"option5b\" value=\"2\">2</option>\n\t\t<option id=\"option5c\" value=\"1\" data-attr=\"\">3</option>\n\t</select>\n\n\t<object id=\"object1\" codebase=\"stupid\">\n\t\t<param name=\"p1\" value=\"x1\" />\n\t\t<param name=\"p2\" value=\"x2\" />\n\t</object>\n\n\t<span id=\"台北Táiběi\"></span>\n\t<span id=\"台北\" lang=\"中文\"></span>\n\t<span id=\"utf8class1\" class=\"台北Táiběi 台北\"></span>\n\t<span id=\"utf8class2\" class=\"台北\"></span>\n\t<span id=\"foo:bar\" class=\"foo:bar\"></span>\n\t<span id=\"test.foo[5]bar\" class=\"test.foo[5]bar\"></span>\n\n\t<foo_bar id=\"foobar\">test element</foo_bar>\n</form>\n<b id=\"floatTest\">Float test.</b>\n<iframe id=\"iframe\" name=\"iframe\"></iframe>\n<form id=\"lengthtest\">\n\t<input type=\"text\" id=\"length\" name=\"test\"/>\n\t<input type=\"text\" id=\"idTest\" name=\"id\"/>\n</form>\n<table id=\"table\"></table>\n\n<form id=\"name-tests\">\n\t<!-- Inputs with a grouped name attribute. -->\n\t<input name=\"types[]\" id=\"types_all\" type=\"checkbox\" value=\"all\" />\n\t<input name=\"types[]\" id=\"types_anime\" type=\"checkbox\" value=\"anime\" />\n\t<input name=\"types[]\" id=\"types_movie\" type=\"checkbox\" value=\"movie\" />\n</form>\n\n<form id=\"testForm\" action=\"#\" method=\"get\">\n\t<textarea name=\"T3\" rows=\"2\" cols=\"15\">?\nZ</textarea>\n\t<input type=\"hidden\" name=\"H1\" value=\"x\" />\n\t<input type=\"hidden\" name=\"H2\" />\n\t<input name=\"PWD\" type=\"password\" value=\"\" />\n\t<input name=\"T1\" type=\"text\" />\n\t<input name=\"T2\" type=\"text\" value=\"YES\" readonly=\"readonly\" />\n\t<input type=\"checkbox\" name=\"C1\" value=\"1\" />\n\t<input type=\"checkbox\" name=\"C2\" />\n\t<input type=\"radio\" name=\"R1\" value=\"1\" />\n\t<input type=\"radio\" name=\"R1\" value=\"2\" />\n\t<input type=\"text\" name=\"My Name\" value=\"me\" />\n\t<input type=\"reset\" name=\"reset\" value=\"NO\" />\n\t<select name=\"S1\">\n\t\t<option value=\"abc\">ABC</option>\n\t\t<option value=\"abc\">ABC</option>\n\t\t<option value=\"abc\">ABC</option>\n\t</select>\n\t<select name=\"S2\" multiple=\"multiple\" size=\"3\">\n\t\t<option value=\"abc\">ABC</option>\n\t\t<option value=\"abc\">ABC</option>\n\t\t<option value=\"abc\">ABC</option>\n\t</select>\n\t<select name=\"S3\">\n\t\t<option selected=\"selected\">YES</option>\n\t</select>\n\t<select name=\"S4\">\n\t\t<option value=\"\" selected=\"selected\">NO</option>\n\t</select>\n\t<input type=\"submit\" name=\"sub1\" value=\"NO\" />\n\t<input type=\"submit\" name=\"sub2\" value=\"NO\" />\n\t<input type=\"image\" name=\"sub3\" value=\"NO\" />\n\t<button name=\"sub4\" type=\"submit\" value=\"NO\">NO</button>\n\t<input name=\"D1\" type=\"text\" value=\"NO\" disabled=\"disabled\" />\n\t<input type=\"checkbox\" checked=\"checked\" disabled=\"disabled\" name=\"D2\" value=\"NO\" />\n\t<input type=\"radio\" name=\"D3\" value=\"NO\" checked=\"checked\" disabled=\"disabled\" />\n\t<select name=\"D4\" disabled=\"disabled\">\n\t\t<option selected=\"selected\" value=\"NO\">NO</option>\n\t</select>\n\t<input id=\"list-test\" type=\"text\" />\n\t<datalist id=\"datalist\">\n\t\t<option value=\"option\"></option>\n\t</datalist>\n</form>\n<div id=\"moretests\">\n\t<form>\n\t\t<div id=\"checkedtest\" style=\"display:none;\">\n\t\t\t<input type=\"radio\" name=\"checkedtestradios\" checked=\"checked\"/>\n\t\t\t<input type=\"radio\" name=\"checkedtestradios\" value=\"on\"/>\n\t\t\t<input type=\"checkbox\" name=\"checkedtestcheckboxes\" checked=\"checked\"/>\n\t\t\t<input type=\"checkbox\" name=\"checkedtestcheckboxes\" />\n\t\t</div>\n\t</form>\n\t<div id=\"nonnodes\"><span id=\"nonnodesElement\">hi</span> there <!-- mon ami --></div>\n\t<div id=\"t2037\">\n\t\t<div><div class=\"hidden\">hidden</div></div>\n\t</div>\n\t<div id=\"t6652\">\n\t\t<div></div>\n\t</div>\n\t<div id=\"no-clone-exception\"><object><embed></embed></object></div>\n</div>\n\n<div id=\"tabindex-tests\">\n\t<ol id=\"listWithTabIndex\" tabindex=\"5\">\n\t\t<li id=\"foodWithNegativeTabIndex\" tabindex=\"-1\">Rice</li>\n\t\t<li id=\"foodNoTabIndex\">Beans</li>\n\t\t<li>Blinis</li>\n\t\t<li>Tofu</li>\n\t</ol>\n\n\t<div id=\"divWithNoTabIndex\">I'm hungry. I should...</div>\n\t<span>...</span><a href=\"#\" id=\"linkWithNoTabIndex\">Eat lots of food</a><span>...</span> |\n\t<span>...</span><a href=\"#\" id=\"linkWithTabIndex\" tabindex=\"2\">Eat a little food</a><span>...</span> |\n\t<span>...</span><a href=\"#\" id=\"linkWithNegativeTabIndex\" tabindex=\"-1\">Eat no food</a><span>...</span>\n\t<span>...</span><a id=\"linkWithNoHrefWithNoTabIndex\">Eat a burger</a><span>...</span>\n\t<span>...</span><a id=\"linkWithNoHrefWithTabIndex\" tabindex=\"1\">Eat some funyuns</a><span>...</span>\n\t<span>...</span><a id=\"linkWithNoHrefWithNegativeTabIndex\" tabindex=\"-1\">Eat some funyuns</a><span>...</span>\n\t<input id=\"inputWithoutTabIndex\"/>\n\t<button id=\"buttonWithoutTabIndex\"></button>\n\t<textarea id=\"textareaWithoutTabIndex\"></textarea>\n\t<menu type=\"popup\">\n\t\t<menuitem id=\"menuitemWithoutTabIndex\" command=\"submitbutton\" default/>\n\t</menu>\n</div>\n\n<div id=\"liveHandlerOrder\">\n\t<span id=\"liveSpan1\"><a href=\"#\" id=\"liveLink1\"></a></span>\n\t<span id=\"liveSpan2\"><a href=\"#\" id=\"liveLink2\"></a></span>\n</div>\n\n<div id=\"siblingTest\">\n\t<em id=\"siblingfirst\">1</em>\n\t<em id=\"siblingnext\">2</em>\n\t<em id=\"siblingthird\">\n\t\t<em id=\"siblingchild\">\n\t\t\t<em id=\"siblinggrandchild\">\n\t\t\t\t<em id=\"siblinggreatgrandchild\"></em>\n\t\t\t</em>\n\t\t</em>\n\t</em>\n\t<span id=\"siblingspan\"></span>\n</div>\n<div id=\"fx-test-group\" style=\"position: absolute; width: 1px; height: 1px; overflow: hidden;\">\n\t<div id=\"fx-queue\" name=\"test\">\n\t\t<div id=\"fadein\" class='chain-test' name='div'>fadeIn<div>fadeIn</div></div>\n\t\t<div id=\"fadeout\" class='chain-test chain-test-out'>fadeOut<div>fadeOut</div></div>\n\n\t\t<div id=\"show\" class='chain-test'>show<div>show</div></div>\n\t\t<div id=\"hide\" class='chain-test chain-test-out'>hide<div>hide</div></div>\n\t\t<div id=\"easehide\" class='chain-test chain-test-out'>hide<div>hide</div></div>\n\n\t\t<div id=\"togglein\" class='chain-test'>togglein<div>togglein</div></div>\n\t\t<div id=\"toggleout\" class='chain-test chain-test-out'>toggleout<div>toggleout</div></div>\n\t\t<div id=\"easetoggleout\" class='chain-test chain-test-out'>toggleout<div>toggleout</div></div>\n\n\t\t<div id=\"slideup\" class='chain-test'>slideUp<div>slideUp</div></div>\n\t\t<div id=\"slidedown\" class='chain-test chain-test-out'>slideDown<div>slideDown</div></div>\n\t\t<div id=\"easeslideup\" class='chain-test'>slideUp<div>slideUp</div></div>\n\n\t\t<div id=\"slidetogglein\" class='chain-test'>slideToggleIn<div>slideToggleIn</div></div>\n\t\t<div id=\"slidetoggleout\" class='chain-test chain-test-out'>slideToggleOut<div>slideToggleOut</div></div>\n\n\t\t<div id=\"fadetogglein\" class='chain-test'>fadeToggleIn<div>fadeToggleIn</div></div>\n\t\t<div id=\"fadetoggleout\" class='chain-test chain-test-out'>fadeToggleOut<div>fadeToggleOut</div></div>\n\n\t\t<div id=\"fadeto\" class='chain-test'>fadeTo<div>fadeTo</div></div>\n\t</div>\n\n\t<div id=\"fx-tests\"></div>\n\t<span id=\"display\"></span>\n</div>\n";
// Compat with QUnit 1.x:
document.getElementById("qunit-fixture").innerHTML = QUnit.config.fixture;