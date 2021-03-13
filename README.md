# Calculator-C-
一个C#语言开发的计算器
- 计算器的功能包括简单的加减乘除以及乘方运算，该计算器还提供了（）的功能以提供优先级的自定义。本计算器基本能确保用户输入算法的合法性，对于不合法的输入，提示其错误的信息。
- 增加了三角函数，取倒数，取余，取对数，x^N,开平方，左右括号等运算，能够进行表达式计算。
一、系统概述
本章的主要内容是设计开发一个支持连续计算的计算器，其过程包括项目分析、界面设计、代码编写、运行调试。通过该项目的开发，使读者进一步了解基于图形用户界面的Windows应用程序的开发过程，并通过项目实训的扩展练习加深印象，为开发较为复杂的应用程序打下基础。
计算器的功能包括简单的加减乘除以及乘方运算，该计算器还提供了（）的功能以提供优先级的自定义。本计算器基本能确保用户输入算法的合法性，对于不合法的输入，提示其错误的信息。
二、系统设计
2.1 设计目标
该项目目标是设计开发一个支持连续计算的四则运算计算器myCalculator，通过单击按钮，输入并完成如5×8+16类似的连续计算，并将运算结果显示在输出文本框中，同时也具备清空、后退等功能，其运行界面见下图1.2.1。

 

图1.2.1运行界面
 
2.2 设计分析与算法流程	 
图1.2.2设计分析与算法流程
计算器的主要功能是完成加减乘除运算，而且支持连续运算，连续计算的实现借助于开发工具中预定义的数据结构Stack（栈），实现。
首先将运算式子输入到文本框中，然后要将中缀式转化为后缀式，这里就需要设置栈内和站外的优先级数。
isp为栈内优先数，icp为栈外优先数。

操作符ch	#	(	√,^sin,cos,tan,ln	*,/%	+,-	)
Isp	0	1	9	5	3	10
icp	0	10	8	4	2	1
图1.2.3 操作符
扫描中缀式，用字符变量ch读取式子，直到ch=“#”。同时栈顶的操作符也是“#”。
①	若ch是操作数直接输出，读入下一个字符。
②若ch是操作数，判断ch的优先级icp和当前位于栈顶的操作符op的优先级isp。
	若icp（ch）>isp(op),令ch进栈，读入下一个字符ch。
	若icp (ch) <isp(op),退栈并输出。 
	若icp(ch)==isp(op),退栈但并不输出，若退出的是‘（’号读入下一字符串ch。
算法结束，输出序列即为后缀式。
利用后缀式求表达式的值，从左向右扫描表达式，并使用一个栈暂存扫描到的操作数或计算结果，
最后就可以得出表达式的值。
2.3 界面设计
计算机项目的软件界面较为简单，采用单窗体设计，操作的按钮全部放置在创建的单窗体上。
进入“工具箱”中，展开“公共控件”，把计算器项目所需要的控件拖到Form_Main窗体上，并设计控件的属性。窗体和控件属性见下表。
 
图1.2.4窗体图

控件类型	控件名称	属性	设置结果


Form	Form1	Name	Form_Main
		Text	MyCalculator
		StartPosition	CenterScreen
		MaximizeMode	False
		AutoSizeMode	GrowAndShrink

TextBox	TextBox1	Name	txtDisplay
		ReadOnly	True
		TextAlign	Right






Button	Button1	Name	btn_0
		Text	0
		FlatStyle	Popup
	Button2	Name	btn_1
		Text	1
		FlatStyle	Popup
	Button3	Name	btn_2
		Text	2
		FlatStyle	Popup
	Button4	Name	btn_3
		Text	3
		FlatStyle	Popup
	Button5	Name	btn_4
		Text	4
		FlatStyle	Popup
	Button6	Name	btn_5
		Text	5
		FlatStyle	Popup
	Button7	Name	btn_6









Button	Button7	Text	6
		FlatStyle	Popup
	Button8	Name	btn_7
		Text	7
		FlatStyle	Popup
	Button9	Name	btn_8
		Text	8
		FlatStyle	Popup
	Button10	Name	btn_9
		Text	9
		FlatStyle	Popup
	Button11	Name	btn_point
		Text	.
		FlatStyle	Popup
	Button12	Name	btn_equal
		Text	=
		FlatStyle	Popup
	Button13	Name	btn_add
		Text	+
		FlatStyle	Popup
	Button14	Name	btn_sub
		Text	-






Button	Button14	FlatStyle	Popup
	Button15	Name	btn_multi
		Text	×
		FlatStyle	Popup
	Button16	Name	btn_div
		Text	÷
		FlatStyle	Popup
	Button17	Name	btn_backspace
		Text	退格
		FlatStyle	Popup
	Button18	Name	btn_clear
		Text	清空
		FlatStyle	Popup

三、系统实现（运行调试）
（1）单击工具条上的“启动”按钮，运行效果图如图
 

图1.3.1运行界面
（2）计算“5×9+5+50”，依次单击按钮“5”、“×”、“9”、“+”、“5”、“+”、“50”，然后单击按钮“=”，显示框的数值为100。
 
图1.3.2计算界面
（3）依次测试“清空”、“退格”等按钮的功能。
四、系统扩展
增加了三角函数，取倒数，取余，取对数，x^N,开平方，左右括号等运算，能够进行表达式计算。

 
图1.4.1取倒数
 
图1.4.2开根号
 
图1.4.3求对数
五、总结

  本节实验的主要内容是设计开发一个支持连续运算的简单计算器，其过程包括项目分析、界面设计、代码编写和运行调试。通过该项目的开发，进一步了解了基于图形用户界面的Windows应用程序的开发过程，并且学会了使用C#中的Stack类，明白了Stack常用的方法及属性，懂得了MessageBoxIcon的属性。这次简单计算器的编写让我获益匪浅，并通过项目实训的拓展练习加深了印象。
