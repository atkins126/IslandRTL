﻿'''<summary>The HTMLTableColElement interface provides special properties (beyond the HTMLElement interface it also has available to it inheritance) for manipulating single or grouped table column elements.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [HTMLTableColElement]
Inherits HTMLElement

  '''<summary>Is an unsigned long that reflects the span HTML attribute, indicating the number of columns to apply this object's attributes to. Must be a positive integer.</summary>
  Property [span] As ULong
End Interface