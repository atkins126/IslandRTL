﻿'''<summary>All of the SVG DOM interfaces that correspond directly to elements in the SVG language derive from the SVGElement interface.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [SVGElement]
  '''<summary>A DOMStringMap object which provides a list of key/value pairs of named data attributes which correspond to custom data attributes attached to the element. These can also be defined in SVG using attributes of the form data-*, where * is the key name for the pair. This works just like HTML's HTMLElement.dataset property and HTML's data-* global attribute.</summary>
  ReadOnly Property [dataset] As String
  '''<summary>An SVGSVGElement referring to the nearest ancestor &lt;svg&gt; element. null if the given element is the outermost &lt;svg&gt; element.</summary>
  ReadOnly Property [ownerSVGElement] As Element
  '''<summary>The SVGElement, which established the current viewport. Often, the nearest ancestor &lt;svg&gt; element. null if the given element is the outermost &lt;svg&gt; element.</summary>
  ReadOnly Property [viewportElement] As Element
End Interface