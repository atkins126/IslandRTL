﻿'''<summary>The AuthenticatorResponse interface of the Web Authentication API is the base interface for interfaces that provide a cryptographic root of trust for a key pair. The child interfaces include information from the browser such as the challenge origin and either may be returned from PublicKeyCredential.response.</summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [AuthenticatorResponse]
  '''<summary>A JSON string in an ArrayBuffer, representing the client data that was passed to CredentialsContainer.create() or CredentialsContainer.get().</summary>
  Property [clientDataJSON] As Byte()
End Interface