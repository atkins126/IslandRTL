﻿'''<summary>The SVGAnimatedPreserveAspectRatio interface is used for attributes of type SVGPreserveAspectRatio which can be animated.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [SVGAnimatedPreserveAspectRatio]
  '''<summary>Is a SVGPreserveAspectRatio that represents the current animated value of the given attribute. If the given attribute is not currently being animated, then the SVGPreserveAspectRatio will have the same contents as baseVal. The object referenced by animVal is always distinct from the one referenced by baseVal, even when the attribute is not animated.</summary>
  ReadOnly Property [animVal] As Dynamic
End Interface