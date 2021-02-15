﻿'''<summary>The HTMLProgressElement interface provides special properties and methods (beyond the regular HTMLElement interface it also has available to it by inheritance) for manipulating the layout and presentation of &lt;progress> elements.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [HTMLProgressElement]
Inherits HTMLElement

  '''<summary>Is a double value reflecting the content attribute of the same name, limited to numbers greater than zero. Its default value is 1.0.</summary>
  Property [max] As Double
  '''<summary>Returns a double value returning the result of dividing the current value (value) by the maximum value (max); if the progress bar is an indeterminate progress bar, it returns -1.</summary>
  ReadOnly Property [position] As Integer
  '''<summary>Is a double value that reflects the current value; if the progress bar is an indeterminate progress bar, it returns 0.</summary>
  Property [value] As String
  '''<summary>Returns NodeList containing the list of  element represents a caption for an item in a user interface.">&lt;label&gt; elements that are labels for this element.</summary>
  ReadOnly Property [labels] As Element()
End Interface