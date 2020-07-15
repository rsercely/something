' this test assumes that you are logged in, have selected the the order name to filter
' it stops all machines, but only if Client is not running.
' My assumption is that if client is running, the order may be in use, so don't stop server or windows

' note that the "page link" is parameterized.
' also note - the first iteration, the number "1" is not a link, it is an element
' and - if a restrictive filter has been used, there may be no page link at all

'Browser("My Orders | Blueshift").Page("My Orders | Blueshift").WebElement("Page 1").Click

iteration = Environment.Value("TestIteration")
If iteration <> 1 Then
	if not Browser("My Orders | Blueshift").Page("My Orders | Blueshift").Link("page link").Exist(10) then
		Exittest ' this code assumes that there are enough orders that there are multiple pages. 
	End If
	Browser("My Orders | Blueshift").Page("My Orders | Blueshift").Link("page link").Click 
End If
wait 20
nrows = Browser("My Orders | Blueshift").Page("My Orders | Blueshift").WebTable("Title").RowCount
For row = 2 To nrows Step 1
	Set titleLink = Browser("My Orders | Blueshift").Page("My Orders | Blueshift").WebTable("Title"). _
		ChildItem(row, 2, "Link", 0)
	BSSessionName = titleLink.getRoProperty("innertext")
	print BSSessionName
	Set orderLink = Browser("My Orders | Blueshift").Page("My Orders | Blueshift").WebTable("Title"). _
		ChildItem(row, 3, "Link", 0)
	orderLink.highlight
	href = orderLink.GetROProperty("href") ' simple click operation doesn't work :-(
	Browser("My Orders | Blueshift").OpenNewTab
'	Setting("DefaultTimeout") = 1*1000 
'	Browser("New Tab").Page("New Tab").Sync @@ hightlight id_;_Browser("Google").Page("Google")_;_script infofile_;_ZIP::ssf9.xml_;_
'	Setting("DefaultTimeout") = 20*1000 
'	Browser("New Tab").Navigate href @@ hightlight id_;_394906_;_script infofile_;_ZIP::ssf10.xml_;_

	Browser("Order information | Blueshift").Navigate href


	For xxx = 1 To 10 Step 1 ' but max of 4 or 5 should  be plenty
		runningRow = Browser("Order information | Blueshift").Page("Order information | Blueshift").WebTable("Instance"). _
			GetRowWithCellText ("Runningrefresh")
		If runningRow = -1 Then
			Exit for
		End If
		If runningRow = 2 Then ' client is running, so don't stop anything
			Exit for
		End If
		
		if xxx = 1 then
			print BSSessionName & " is being stopped"
		end if 
		Set running = Browser("Order information | Blueshift").Page("Order information | Blueshift").WebTable("Instance"). _
			ChildItem(runningRow,4,"WebList",0)
		running.highlight
		running.Select "Stop"
		Set executeButton = Browser("Order information | Blueshift").Page("Order information | Blueshift").WebTable("Instance"). _
			ChildItem(runningRow,4,"WebButton",0)
		executeButton.highlight
		executeButton.click
		wait 10
		Set statusButton = Browser("Order information | Blueshift").Page("Order information | Blueshift").WebTable("Instance"). _
			ChildItem(runningRow,2,"Link",0)
		statusButton.click
	Next
	Browser("Order information | Blueshift").Close
Next

foo = 1 ' to set a breakpoint if desired @@ hightlight id_;_Browser("My Orders | Blueshift").Page("My Orders | Blueshift").Link("2")_;_script infofile_;_ZIP::ssf6.xml_;_

