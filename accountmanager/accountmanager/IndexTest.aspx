<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexTest.aspx.cs" Inherits="accountmanager.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<html lang="en" class="noBoard">
<head>
	<title>Account! - Basic Interface</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">
	<meta name="apple-mobile-web-app-capable" content="yes" />

	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

	<style>
		html, body {
			display: flex;
			flex-direction: column;
			width: 100%;
			margin: 0px;
			padding: 0px;
			overflow: hidden;
			font-family: 'Century Gothic';
		}

		body {
			height: 100%;
		}

		button {
			border: 1px solid gray;
			border-radius: 25px;
			background-color: #008cff;
			color: white;
		}

		.titleContainer {
			background-color: lightgray;
			display: flex;
			flex-direction: row;
			align-items: center;
			border: 1px solid gray;
			border-radius: 25px;
			padding-left: 10px;
			padding-right: 10px;
		}

		.menu {
			flex: 1;
			text-align: right;
			color: #bbbbbb;
			visibility:hidden;
		}

			.menu a {
				font-size: small;
				color: blue;
			}

		.contentContainer {
			flex: 1;
			position: relative;
			margin: 5px;
		}

		.contentPanel {
			position: absolute;
			top: 0px;
			left: 0px;
			height: 100%;
			width: 100%;
			visibility: hidden;
			flex: 1;
			/*border: 1px solid gray;
			border-radius: 25px;*/
		}

		.logonPanel {
			text-align: center;
		}

		.accountsPanel {
			text-align: center;
		}

		.logonBox {
			display: inline-block;
			text-align: right;
		}

			.logonBox div {
				padding: 0px;
				margin: 0px;
			}

			.logonBox hr {
				padding: 0px;
				margin: 0px;
			}

			.logonBox input {
				width: 100px;
				border: 1px inset gray;
			}

		.newAccountPanel {
			text-align: center;
		}

		.newAccountBox {
			display: inline-block;
			text-align: right;
		}

			.newAccountBox input {
				width: 100px;
				border: 1px inset gray;
			}

			.newAccountBox hr {
				padding: 0px;
				margin: 0px;
			}

		.accountsBox {
			display: inline-block;
			width: 100%;
		}

			.accountsBox hr {
				padding: 0px;
				margin-left:auto;
				margin-right:auto;
				width: 40px;
			}

		.accountRow {
			margin-left:auto;
			margin-right:auto;
			width: 100%;
		}

		.chatPanel {
			display: flex;
			flex-direction: column;
		}

		.messagesPanel {
			overflow-y: scroll;
			margin-top: 20px;
			flex: 1;
		}

		.nameTag {
			font-weight: bold;
			font-size:small;
			text-decoration:none;
			color:black;
		}

		.msg {
			margin-top: 5px;
		}

		.chatInputPanel {
			height: 40px;
			margin-top: 10px;
			border-top: 1px solid #bbbbbb;
			border-left: none;
			border-right: none;
			border-bottom: none;
			padding-left: 20px;
			padding-right: 20px;
			padding-bottom: 2px;
			display: flex;
			flex-direction: row;
		}

		.chatInput {
			width: 100%;
			height: 100%;
			overflow: hidden;
			border: none;
		}

		.tinyLink {
			font-size: smaller;
			text-decoration: none;
			color: blue;
		}

		.noBoard {
			height: 100%;
		}

		.board {
			height: 50%;
		}

		.sendButton {
			margin-top: 7px;
			width: 20px;
			height: 20px;
		}

		.left {
			text-align: left;
		}

		.optionsTag {
			float: right;
			font-size: small;
			color: blue;
		}
	</style>

	
</head>

<body>

	<div class="titleContainer">
		<span>Account!</span>
		<div id="menu" class="menu">
			<a href="#" id="adminLink" onclick="adminClick()"></a> 
			<a href="#" onclick="LogOff()">log off</a>
		</div>
	</div>

	<div class="contentContainer">

		<div id="logonPanel" class="contentPanel logonPanel">
			<div class="logonBox">
				<form onsubmit="LogOn($('#logonId').val(), $('#logonPassword').val()); return false;">
					<div class="left">Logon</div>
					<div><a href="#" onclick="showPanel('newAccountPanel')" class="tinyLink">...or request an account</a></div>
					<hr />
					<div>
						ID: <input type="text" id="logonId" />
					</div>
					<div>
						Pwd: <input type="password" id="logonPassword" />
					</div>
					<hr />
					<div>
						<button type="submit">Go!</button>
					</div>
				</form>

			</div>
		</div>

		<div id="accountsPanel" class="contentPanel">
			<div class="left">Users</div>
			<div class="left" style="font-size:smaller">click a name to send an email</div>
			<hr />
			<div class="accountsBox" id="accountsBox">


			</div>
		</div>

		<div id="requestsPanel" class="contentPanel">
			<div class="left">Account requests</div>
			<hr />
			<div class="accountsBox" id="requestsBox">


			</div>
		</div>

		<div id="newAccountPanel" class="contentPanel newAccountPanel">
			<div class="newAccountBox">
				<form onsubmit="CreateAccount($('#newLogonId').val(), $('#newLogonPassword').val(), $('#newLogonFName').val(), $('#newLogonLName').val(), $('#newLogonEmail').val()); return false;">
					<div class="left">Request Account</div>
					<div><a href="#" onclick="showPanel('logonPanel')" class="tinyLink">...or log on</a></div>
					<hr />
					<div>
						ID: <input type="text" id="newLogonId" />
					</div>
					<div>
						Pwd: <input type="password" id="newLogonPassword" />
					</div>
					<div>
						First: <input type="text" id="newLogonFName" />
					</div>
					<div>
						Last: <input type="text" id="newLogonLName" />
					</div>
					<div>
						Email: <input type="text" id="newLogonEmail" />
					</div>
					<hr />
					<div>
						<button type="submit">Go!</button>
					</div>
				</form>

			</div>
		</div>

		<div id="editAccountPanel" class="contentPanel newAccountPanel">
			<div class="newAccountBox">
				<form onsubmit="EditAccount(); return false;">
					<div class="left">Edit Account</div>
					<div><a href="#" onclick="DeactivateAccount()" class="tinyLink">...or deactivate</a></div>
					<hr />
					<div>
						ID: <input type="text" id="editLogonId" />
					</div>
					<div>
						Pwd: <input type="password" id="editLogonPassword" />
					</div>
					<div>
						First: <input type="text" id="editLogonFName" />
					</div>
					<div>
						Last: <input type="text" id="editLogonLName" />
					</div>
					<div>
						Email: <input type="text" id="editLogonEmail" />
					</div>
					<hr />
					<div>
						<button type="submit">Save</button>
					</div>
				</form>

			</div>
		</div>

	</div>

</body>
</html>
