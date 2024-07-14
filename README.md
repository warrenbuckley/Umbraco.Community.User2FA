# Umbraco Community User2FA
This is a simple package designed for Umbraco V14+ that adds Two Factor Auth (2FA) login to Umbraco backoffice users.

This is based on an Umbraco Docs tutorial, howver I saw this tutorial as mostly plumbing of creating C# files in order to add 2FA and thus package is designed to help save you time in creating these files over and over again.

## How to use
* Install the Nuget package into your Umbraco V14 site
* Login to Umbraco backoffice
* Click User avatar top right 
* Click button labeled Configure Two Factor
* Enable Two Factor by scanning QR code with a phone such as

## 2FA Mobile Applications
* Microsoft Authenticator [(iOS)](https://apps.apple.com/us/app/microsoft-authenticator/id983156458) | [(Android)](https://play.google.com/store/apps/details?id=com.azure.authenticator&hl=en_GB)
* Google Authenticator [(iOS)](https://apps.apple.com/us/app/google-authenticator/id388497605) | [(Android)](https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&hl=en_GB&pli=1)
* Twilio Authy [(iOS)](https://apps.apple.com/us/app/twilio-authy/id494168017) | [(Android)](https://play.google.com/store/apps/details?id=com.authy.authy)

I have also verified this to work with 1Password Desktop App to save/store the 2FA QR code and generate the correct pin.

## Configuration

| Configuration Key					| Description |
| ---------------------------------	| ----------- |
| `User2FA:AuthenticatorIssuerName` | This is the name that will be displayed in the 2FA app when you scan the QR code, this is useful if you have multiple Umbraco sites and want to differentiate between them. |

```json
{
	...

	"Umbraco": {
		...
	},
	"User2FA": {
		"AuthenticatorIssuerName": "My Awesome Website"
	}
	
	...
}
```


### Contributing
The example website project has a backoffice user account setup ready to have a 2FA account applied to it, you can login in with the following credentials.

| Username              | Password      |
| --------------------- | ------------- |
| warren@hackmakedo.com | password1234  |


#### Attribution
<a href="https://www.flaticon.com/free-icons/qr-code" title="qr code icons">Qr code icons created by small.smiles - Flaticon</a>

---

_Lovingly crafted for you by [Warren Buckley](https://github.com/sponsors/warrenbuckley)❤️_<br/>
_[Available for hire](https://hackmakedo.com/)_
