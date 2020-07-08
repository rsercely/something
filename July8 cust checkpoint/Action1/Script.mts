Browser("Advantage Shopping").Page("Advantage Shopping").Link("HeadphonesCategoryTxt").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("HeadphonesCategoryTxt")_;_script infofile_;_ZIP::ssf1.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Beats Studio 2 Over-Ear").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Beats Studio 2 Over-Ear")_;_script infofile_;_ZIP::ssf2.xml_;_
If Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("score object").Exist (30) Then
	wait 2
	Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("score object").Check CheckPoint("score checkpoint")
End If

curScore = Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("score object").GetROProperty ("innertext") @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("9.3")_;_script infofile_;_ZIP::ssf3.xml_;_
If cdbl(curScore) > 9.0 Then
	Reporter.ReportEvent micPass, "check Score", "Everything is a ok the score is greate"
then
	Reporter.ReportEvent micFail, "check Score", "Oh no we are terrible"
End If



Browser("Advantage Shopping").Page("Advantage Shopping").Link("HOME").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("HOME")_;_script infofile_;_ZIP::ssf4.xml_;_
