' this test assumes that you are logged in, have selected the the order name to filter
' it stops all machines, but only if Client is not running.
' My assumption is that if client is running, the order may be in use, so don't stop server or windows

' note that the "page link" is parameterized.

if not Browser("My Orders | Blueshift").Page("My Orders | Blueshift").Link("page link").Exist(10) then
	Exittest ' this code assumes that there are enough orders that there are multiple pages. Comment this line out if there are not
End If

Browser("My Orders | Blueshift").Page("My Orders | Blueshift").Link("page link").Click ' also comment out this if not multiple pages

nrows = Browser("My Orders | Blueshift").Page("My Orders | Blueshift").WebTable("Title").RowCount

For row = 2 To nrows Step 1
	Set orderLink = Browser("My Orders | Blueshift").Page("My Orders | Blueshift").WebTable("Title"). _
		ChildItem(row, 3, "Link", 0)
	orderLink.highlight
	href = orderLink.GetROProperty("href") ' simple click operation doesn't work :-(
	Browser("My Orders | Blueshift").OpenNewTab
	Browser("Google").Page("Google").Sync @@ hightlight id_;_Browser("Google").Page("Google")_;_script infofile_;_ZIP::ssf9.xml_;_
	Browser("Google").Navigate href @@ hightlight id_;_394906_;_script infofile_;_ZIP::ssf10.xml_;_


	For xxx = 1 To 10 Step 1 ' but max of 4 or 5 should  be plenty
		runningRow = Browser("Order information | Blueshift").Page("Order information | Blueshift").WebTable("Instance"). _
			GetRowWithCellText ("Runningrefresh")
		If runningRow = -1 Then
			Exit for
		End If
		If runningRow = 2 Then ' client is running, so don't stop anything
			Exit for
		End If
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

