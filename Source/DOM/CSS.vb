﻿'''<summary>The CSS interface holds useful CSS-related methods. No object with this interface are implemented: it contains only static methods and therefore is a utilitarian interface.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [CSS]
  '''<summary>Returns a Boolean indicating if the pair property-value, or the condition, given in parameter is supported.</summary>
  Function [supports]([parpropertyName] As Dynamic, [parvalue] As Dynamic) As Boolean
End Interface