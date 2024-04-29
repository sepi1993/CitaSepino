B4A=false
Group=Default Group
ModulesStructureVersion=1
Type=Service
Version1144
@EndOfDesignText@
#Region  Service Attributes 
	#StartAtBoot:true
	#ExcludeFromLibrary: 
#end Region

تست اخر توسط ugd309انجام گردید'
This is main process
end Sub Process_Globals
	'These global variables was be declared once when the application starts.
	'These variables can be accessed from all modules.
Private dm as string = "bye srpi HOW ARE YOU?"
End Sub
Sub Service_Create
	'This is the program entry point.
	'This is a good place to load resources that are not specific to a single activity.

End Sub

Sub Service_Start (StartingIntent As Intent)
	Service.StopAutomaticForeground 'Starter service can start in the foreground state in some edge cases.
End Sub

Sub Service_TaskRemoved
	'This event will be raised when the user removes the app from the recent apps list.
End Sub

'Return true to allow the OS default exceptions handler to handle the uncaught exception.
Sub Application_Error (Error As Exception, StackTrace As String) As Boolean
	Return false
End Sub

Sub Service_Destroy

End Sub
