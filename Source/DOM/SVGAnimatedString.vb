﻿'''<summary>The SVGAnimatedString interface represents string attributes which can be animated from each SVG declaration. You need to create SVG attribute before doing anything else, everything should be declared inside this.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [SVGAnimatedString]
  '''<summary>This is a DOMString representing the animation value. If the given attribute or property is being animated it contains the current animated value of the attribute or property. If the given attribute or property is not currently being animated, it contains the same value as baseVal.</summary>
  ReadOnly Property [animVal] As String
  '''<summary>This is a DOMString representing the base value. The base value of the given attribute before applying any animations. Setter throws DOMException.</summary>
  Property [baseVal] As String
End Interface