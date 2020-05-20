'Browser("Advantage Shopping").Page("Advantage Shopping").Link("HeadphonesCategoryTxt").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("HeadphonesCategoryTxt")_;_script infofile_;_ZIP::ssf1.xml_;_
'Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Beats Studio 2 Over-Ear").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Beats Studio 2 Over-Ear")_;_script infofile_;_ZIP::ssf2.xml_;_
'
'
'curScore = Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("score").GetROProperty("text")
'
'If curScore > 9 Then
'	
'      Reporter.ReportEvent micFail, "dfsdf", "dfsdfdfsdf"
'End If
'Browser("Advantage Shopping").Page("Advantage Shopping").Sync @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping")_;_script infofile_;_ZIP::ssf4.xml_;_
