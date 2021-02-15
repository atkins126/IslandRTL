﻿'''<summary>The WebXR Device API's XRBoundedReferenceSpace interface describes a virtual world reference space which has preset boundaries. This extends XRReferenceSpace, which describes an essentially unrestricted space around the viewer's position.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [XRBoundedReferenceSpace]
  '''<summary>An array of DOMPointReadOnly objects, each of which defines a vertex in the polygon defining the boundaries within which the user will be required to remain. These vertices must be sorted such that they move clockwise around the viewer's position.</summary>
  ReadOnly Property [boundsGeometry] As DOMPointReadOnly()
End Interface