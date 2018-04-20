
/* Css by: Rokas 
/*
https://creativecommons.org/licenses/by/4.0/
Copyright (c) 2017 Chillout Susan
You are free to:
Share — copy and redistribute the material in any medium or format
Adapt — remix, transform, and build upon the material
for any purpose, even commercially.
 This license is acceptable for Free Cultural Works.
The licensor cannot revoke these freedoms as long as you follow the license terms.
Under the following terms:
Attribution — You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.
No additional restrictions — You may not apply legal terms or technological measures that legally restrict others from doing anything the license permits.
You are not allowed to edit the last section of the code.
Notices:
You do not have to comply with the license for elements of the material in the public domain or where your use is permitted by an applicable exception or limitation.
No warranties are given. The license may not give you all of the permissions necessary for your intended use. For example, other rights such as publicity, privacy, or moral rights may limit how you use the material.
 
              
              `|`
              `|`
              `V Read This is Requested*`        
  `This There YOu are Allowed | Copy But Dont change Css Onwer and who created`                                    
                                                                               
theme Version: 1.9 */

/*i see you looking around here*/
/*
# Room:			Nxdc
# Author:		Bevardis
# Made for:		
# Created:		2.3.2018
## WARNING ##
You are NOT allowed using this file without creator's permission!

*/
}
#room-settings .general-settings .description .value {
    overflow-x: hidden;
    overflow-y: hidden;
}
#room-settings .general-settings .description .value a[href*=".php"] {
	display: none;
}
{
	font-family:Tahoma, sans-serif !important;
}

}
.room-background{background:url('https://cdn.radiant.dj/rcs/bg/1.png') !important;}
}
#chat .welcome {
    color: #27b2e9;
    border-top: #27b2e9 2px dotted;
    border-left: #27b2e9 2px dotted;
    border-bottom: #27b2e9 2px dotted;
    border-right: #27b2e9 2px dotted;
}
/* Plug Menu */

#app-menu {
	background:none;
	border:none;
}

#app-menu .button {
	background:#2878BA;
	box-shadow:0.1px 0 10px #000;
	height:54px;
	transition:0.5s;
}

#app-menu .list {
	background:rgba(0,0,0,0.4);
}

#app-menu .list .item {
	box-shadow:none;
	transition:0.5s;
}

#app-menu .list .item:hover {
	background:rgba(50,87,125,0.5);
	box-shadow:inset 3px 0 0 #32577d;
}

#app-menu .list .logout {
	position:relative; left:0; bottom:0;
	width:100%;
	height:55px;
	border:none;
	text-align:left;
	transition:0.5s;
}

#app-menu .list .logout i {
	display:none;
}

#app-menu .list .logout div {
	position:relative;
	top:16px;
	float:left;
	margin-left:10px;
}

#app-menu .list .logout:hover {
	border:none;
	background:rgba(192,64,67,0.5);
	box-shadow:inset 3px 0 0 #C04043;
}

#app-menu .list .rcsunload {

}

/* Header */

.app-header {
	background:#1C3146;
	box-shadow:0 1px 10px #000;
}

.bar-divider {
	background:#fff;
}

.dark-label {
	color:#aaa;
}

#rs-skip-button {
	background:#2878BA !important;
	box-shadow:-1px 0px 10px #000 !important;
	right:54px !important;
	transition:0.5s !important;
}

#rs-skip-button:hover {
	background:#2878BA !important;
	box-shadow:0 0 0 #000, inset 0 0 8px #000 !important;
}

#history-button {
	background:#2878BA;
	transition:0.5s;
	z-index:2;
	box-shadow:5px 0px 10px -5px #000 !important;
}

#history-button:hover {
	background:#2878BA;
	box-shadow:0 0 0 #000, inset 0 0 8px #000 !important;
}


#history-button.selected {
	background:#2878BA !important;
	box-shadow:0 0 0 #000, inset 0 0 20px #000 !important;
}

#header-panel-bar {
	box-shadow:inset 0px -3px #444;
}

.header-panel-button {
	box-shadow:none;
	border:none;
	transition:0.5s;
	opacity:0.6;
}

#header-panel-bar .header-panel-button:hover {
	opacity:1;
	background:none;
}

.header-panel-button.selected {
	box-shadow:inset 0px -3px #2878BA, inset 0 0 20px #000;
	opacity:1;
	background:none;
}

/* Chat */

#chat-header {
	background:#222;
}

#chat-header .divider {
	display:none;
}

#chat-header, #chat-messages {
	border-bottom:1px solid #222;
}

#chat {
	background:#1C3146;
}

#chat .welcome {
	color:#4aaee7;
}

/* User Lists */

#user-lists, #waitlist {
	background:#1C3146;
}

#user-lists .header, #waitlist .header {
	background:#222;
}

#user-lists .header .button {
	transition:0.5s;
	border-radius:20px;
}

#user-lists .header .button.room.selected {
	border:none;
	box-shadow:inset 0 0 30px #4aaee7;
}

#user-lists .header .button.staff.selected {
	border:none;
	box-shadow:inset 0 0 30px #1CA949;
}

#user-lists .header .button.bans.selected,
#user-lists .header .button.mutes.selected,
#user-lists .header .button.ignored.selected {
	border:none;
	box-shadow:inset 0 0 30px #C04043;
}

#user-lists .list .user {
	transition:0.5s;
}

#user-lists .list .user:hover {
	background:#324558;
}

#user-lists .list.staff .group {
	background:#192c3f;
	border:1px solid #4aaee7 !important;
	width:340px;
}

#user-lists .list.bans .user .label, #user-lists .list.mutes .user .label {
	color:#4aaee7;
}

#user-lists .list.bans .user .timestamp, #user-lists .list.mutes .user .expires {
	color:#aaa;
}

/* Waitlist */

#waitlist .list .user {
	background:none;
	transition:0.5s;
}

#waitlist .list .user:hover {
	background:#324558;
}

#waitlist .list .user .is-staff .name {
	color:#1CA949;
}

/* Friends */

.app-right .friends {
	background:#1C3146;
}

.app-right .friends.has-requests .header {
	top:49px !important;
	box-shadow:inset 0 -3px 0 #444;
	transition:0.5s;
	background:#1C3146;
}

.app-right .friends .header i {
	background:#4aaee7;
}

#friends-button.notify .request-count {
	background:#2878BA;
	border:16px;
	padding:4px 4px;
}

.app-right .friends.has-requests .header:hover {
	box-shadow:inset 0 -3px 0 #2787BA, inset 0 -10px 20px -5px #2878BA;
}

.app-right .friends.has-requests .list-header {
	top:0 !important;
	background:#222;
}

.app-right .friends .list-header {
	border:none !important;
	background:#222;
}

.app-right .friends .list .row {
	transition:0.5s;
}

.app-right .friends .list .row:hover {
	box-shadow:inset 3px 0 0 #89be6c;
	background:rgba(137,190,108,0.2);
}

.app-right .friends .list .row.is-offline:hover {
	box-shadow:inset 3px 0 0 #C04043;
	background:rgba(192,64,67,0.2);
}

.app-right .friends .list .row .room {
	transition:0.5s;
}

.app-right .friends .list .row:hover .room,
.app-right .friends .list .row.clickable:hover .room {
	padding:12px;
	background:#89BE6C;
	top:-11px;
	color:#fff;
	text-decoration:none;
}

.app-right .friends .list .row.is-offline:hover .room {
	background:#C04043;
}

/* RCS */

#rcs-menu {
	background:#1C3146;
}

#rcs-menu .header {
	background:#222;
}

#rcs-menu .group {
	background:#2878BA;
}

#rcs-menu .item {
	transition:0.5s;
}

#rcs-menu .item:hover {
	background:#324558;
}

.input-background, #rcs-menu .search {
	background:rgba(44,181,232,0.2) !important;
	transition:0.3s;
}

.input-background.focused, #rcs-menu .search.focused {
	box-shadow:inset 0 0 10px #000 !important;
	border:none;
}

/* Footer */

#footer {
	background:#1C3146;
	box-shadow:0 0 10px #000;
}

#footer-user .buttons .button {
	box-shadow:none !important;
	opacity:0.6;
	transition:0.5s;
}

#footer-user .buttons .button:hover {
	opacity:1;
	background:none !important;
	box-shadow:inset 0 0 20px #000 !important;
}

#footer-user .info.showing {
	box-shadow:0 0 10px #000;
	border-radius:10px;
	border-bottom:2px solid #2878BA;
	background:#222;
}

#footer-user .info .meta div.bar {
	border-radius:10px;
}

#footer-user .info .meta div.bar .progress {
	border-radius:10px;
	background:#2878ba;
	box-shadow:inset 0 0 10px #4aaee7;
}

#footer-user .buttons .button.settings .icon {
	transition:0.5s;
}

#footer-user .buttons .button.settings:hover .icon {
	transform: rotate(360deg);
}

#footer-user .back, #footer-user .signup {
	background:#1C3146;
transition:0.5s;
}

#footer-user .back:hover, #footer-user .signup:hover {
	box-shadow:inset 0 0 20px #000;
}

#playlist-button {
	background:#2878ba;
}

/* Plug Place */

#dj-button {
	background:rgba(0,0,0,0.3);
}

#dj-button.is-leave .left, #dj-button.is-quit .left {
	background:rgba(192,64,67,0.6);
}

#dj-button .left {
	background:rgba(74,174,231,0.4);
}

#vote {
	background:rgba(0,0,0,0.3);
	border-radius:0 0 20px 20px;
}

#vote #woot, #vote #grab, #vote #meh {
	background:transparent;
}

.votes-rs {
	background:rgba(0,0,0,0.6) !important;
}

	/* Woot */

	.votes-rs .title.woot {
		background:#1CA949 !important;
	}

	#vote #woot .bottom {
		box-shadow:inset 0 -3px 0 #1CA949;
		background:none;
		border-radius:0 0 0 20px;
	}

	#vote #woot.selected {
		box-shadow:inset 0 0 30px #1CA949;
		background:none;
		border-radius:0 0 0 20px;
	}

	/* Grab */

	.votes-rs .title.grab {
		background:#4aaee7 !important;
	}

	#vote #grab .bottom {
		box-shadow:inset 0 -3px 0 #4aaee7;
		background:none;
	}

	#vote #grab.selected {
		box-shadow:inset 0 0 30px #4aaee7;
		background:none;
	}

	.pop-menu.grab .bar {
		background:rgba(74,174,231,0.6) !important;
	}

	.pop-menu.grab li:hover {
		background:rgba(74,174,231,0.3) !important;
	}

	/* Meh */

	.votes-rs .title.meh {
		background:#C04043 !important;
	}

	#vote #meh .bottom {
		box-shadow:inset 0 -3px 0 #C04043;
		background:none;
		border-radius:0 0 20px 0;
	}

	#vote #meh.selected {
		box-shadow:inset 0 0 30px #C04043;
		background:none;
		border-radius:0 0 20px 0;
	}

/* Playback */

#playback .background img {
	display:none;
}

/* User meta */

#user-rollover {
	background:rgba(0,0,0,0.6);
	border-radius:10px 10px 0 0;
}

#user-rollover .info {
	background:#1C3146;
}

#user-rollover.is-staff .thumb, #waitlist .is-staff .thumb {
	border-color:#4aaee7 !important;
}

#user-rollover .actions .action {
	transition:0.5s !important;
	box-shadow:none;
}

#user-rollover .actions .action:hover {
	background:none;
}

#user-rollover .actions .giftsub:hover {
	box-shadow:inset 0 0 0 1px #c59840, inset 0 0 40px #000;
	background:none;
}

#user-rollover .actions .skip:hover,
#user-rollover .actions .mention:hover,
#user-rollover .actions .gift:hover,
#user-rollover .actions .friend:hover,
#user-rollover .actions .mod-dj:hover {
	box-shadow:inset 0 -1px 0 #fff, inset 0 0 40px #000 !important;
}

#user-rollover .actions .ignore:hover,
#user-rollover .actions .mod-mute:hover,
#user-rollover .actions .mod-ban:hover {
	box-shadow:inset 0 -1px 0 #C04043, inset 0 0 40px #000 !important;
}

#user-rollover .actions .mod-staff:hover {
	box-shadow:inset 0 -1px 0 #1CA949, inset 0 0 40px #000 !important;
}

/* User Menu */

#user-view {
	background:#000;
}

#user-menu {
	background:#1C3146;
}

#user-menu .avatar {
	background: #1c3146;
	background: -moz-linear-gradient(top,  #1c3146 0%, #4aaee7 80%, #2878ba 100%);
	background: -webkit-linear-gradient(top,  #1c3146 0%,#4aaee7 80%,#2878ba 100%);
	background: linear-gradient(to bottom,  #1c3146 0%,#4aaee7 80%,#2878ba 100%);
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#1c3146', endColorstr='#2878ba',GradientType=0 );
}

#user-menu .item {
	color:#888;
	transition:0.5s;
}

#user-menu .item:hover {
	color:#fff;
}

#user-menu .item.selected {
	box-shadow:inset 3px 0 0 #4aaee7;
	color:#fff;
	background:none;
}

#user-menu .item.notify .count {
	background:#2878BA;
	border:16px;
	padding:4px 4px;
	color:#fff;
	margin-top:-5px;
}

/* Profile */

.user-content.profile .meta.is-staff .role span {
	color:#1CA949;
}

.user-content.profile .meta .blurb .box {
	background:#1C3146;
}

.user-content.profile .meta .blurb input {
	background:#1C3146;
	box-shadow:0 0 0 1px #2878ba;
}

.user-content.profile .meta .joined,
.user-content.profile .points .label {
	color:#777;
}

.user-content .header span {
	color:#4aaee7;
}

.experience .xp .bar {
	height: 30px;
	background: #000;
	box-shadow:inset 0 0 0 2px #1C3146;
	margin:0 auto;
}

.experience .xp .bar .progress {
	display: block;
	height: 100%;
	background:#1C3146;
}


.experience .levels .level .label,
.experience .levels .level.mystery .label {
	background:#1C3146;
}

.experience .levels .level .label i.icon-sunburst {
	background:none !important;
}

.experience .levels .level {
	background:#111;
	box-shadow:inset 0 -1px 10px -1px #1C3146;
	transition:0.5s;
}

.experience .levels .level:hover {
	background:#111;
	box-shadow:inset 0 -1px 10px -1px #2878ba;
	transition:0.5s;
}

.experience .levels .level.earned {
	background:#111;
	box-shadow:inset 0 -3px 20px -1px #1C3146;
	transition:0.5s;
}

.experience .levels .level.earned:hover {
	box-shadow:inset 0 -3px 20px -2px #2878ba;
}

.experience .levels .level.earned .label {
	transition:0.5s;
}

.experience .levels .level.earned:hover .label {
	background:#2878ba;
	transition:0.5s;
}

/* Items */

.user-content .tab-menu button {
	background:#000;
	box-shadow:inset 0 -3px 0 #444 !important;
	transition:0.5s;
}

.user-content .tab-menu button.selected {
	background:#000;
	box-shadow:inset 0 -3px 0 #2878ba !important;
}

.dropdown {
	background:#1C3146;
}

.dropdown dt {
	box-shadow:inset -39px 0 0 #2878ba;
}

.user-content .grid .cell .top,
#user-inventory .badges .grid .cell {
	background: rgb(28,49,70);
	background: -moz-linear-gradient(top,  rgba(28,49,70,1) 0%, rgba(41,137,216,1) 71%, rgba(32,124,202,1) 72%, rgba(28,49,70,1) 100%);
	background: -webkit-linear-gradient(top,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	background: linear-gradient(to bottom,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#1c3146', endColorstr='#1c3146',GradientType=0 );
	opacity:0.6;
}

.user-content .grid .cell:hover .top,
#user-inventory .badges .grid .cell:hover {
	background: rgb(28,49,70);
	background: -moz-linear-gradient(top,  rgba(28,49,70,1) 0%, rgba(41,137,216,1) 71%, rgba(32,124,202,1) 72%, rgba(28,49,70,1) 100%)
	background: -webkit-linear-gradient(top,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	background: linear-gradient(to bottom,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#1c3146', endColorstr='#1c3146',GradientType=0 );
	opacity:1;
}

#user-inventory .avatars .grid .cell,
#user-inventory .badges .grid .cell,
.user-content .grid .cell,
.user-content.communities .grid .cell {
	border-radius:10px;
}

#user-inventory .history .legend {
	color:#4aaee7;
}

#user-inventory .history .list .row {
	background:#1C3146;
}

#user-inventory .history .list .row .item {
	background:#2878ba;
}

/* Shop */

.user-content .grid .cell, .user-content.communities .grid .cell {
	background:#000;
	box-shadow:inset 0 -2px 20px -2px #2878ba;
}

#user-store .badges .grid .cell .top,
#user-store .misc .grid .cell .top {
	background: rgb(28,49,70);
	background: -moz-linear-gradient(top,  rgba(28,49,70,1) 0%, rgba(41,137,216,1) 71%, rgba(32,124,202,1) 72%, rgba(28,49,70,1) 100%);
	background: -webkit-linear-gradient(top,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	background: linear-gradient(to bottom,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#1c3146', endColorstr='#1c3146',GradientType=0 );
}

#user-store .badges .grid .cell:hover .top,
#user-store .misc .grid .cell:hover .top {
	background: rgb(28,49,70);
	background: -moz-linear-gradient(top,  rgba(28,49,70,1) 0%, rgba(41,137,216,1) 71%, rgba(32,124,202,1) 72%, rgba(28,49,70,1) 100%);
	background: -webkit-linear-gradient(top,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	background: linear-gradient(to bottom,  rgba(28,49,70,1) 0%,rgba(41,137,216,1) 71%,rgba(32,124,202,1) 72%,rgba(28,49,70,1) 100%);
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#1c3146', endColorstr='#1c3146',GradientType=0 );
}

/* Friends */

#user-friends .tab-menu button .count {
	background: #2878BA;
	border: 16px;
	padding: 4px 4px;
	top:10px;
}

#user-friends .list {
	background:#1C3146;
}

#user-friends .list .row {
	opacity:0.6;
	transition:0.5s;
	background:#1C3146;
}

#user-friends .list .row:hover {
	opacity:1;
	box-shadow:inset 3px 0 0 #89be6c;
	background:rgba(137,190,108,0.2);
}

#user-friends .list .row.is-offline:hover {
	opacity:1;
	box-shadow:inset 3px 0 0 #C04043;
	background:rgba(192,64,67,0.2);
}

#user-friends .list .row .buttons button {
	background:none !important;
	transition:0.5s;
}

#user-friends .list .row:hover .buttons button.positive {
	background:rgba(40,120,186,0.4) !important;
}

#user-friends .list .row:hover .buttons button.positive:hover {
	background:rgba(40,120,186,0.8) !important;
}

#user-friends .list .row:hover .buttons button.negative {
	background:rgba(192,64,67,0.4) !important;
}

#user-friends .list .row:hover .buttons button.negative:hover {
	background:rgba(192,64,67,0.8) !important;
}

#user-friends .list .row .joined {
	color:#777;
}

#user-friends .search {
	background:rgba(44,181,232,0.2);
	transition:0.3s;
}

#user-friends .search.focused {
	box-shadow:inset 0 0 10px #000 !important;
	border:none;
}

/* Recently Played */

.media-list.history .score .grabs span {
	color:#4aaee7;
}

.media-list.history .score .positive {
	color:#1CA949;
}

.media-list.history .score .negative {
	color:#C04043;
}

.media-list.history .row {
	transition:0.5s;
}

.media-list.history .row:hover {
	background:rgba(40,120,186,0.4) !important;
}

/* Communities */

.user-content.communities button {
	background:#2878ba;
}

/* Settings */

#user-settings .container .subscribe-button {
	box-shadow:inset 0 0 0 1px transparent, inset 0 0 40px #000;
	transition:0.5s;
}

#user-settings .container .subscribe-button:hover {
	box-shadow:inset 0 0 0 1px #c59840, inset 0 0 40px #000;
}


/* Custom CSS */

#room-settings .general-settings .description .value a:last-of-type {
	display:none !important;
}

#room-settings .general-settings .description .value:after {
	content:" Nieko čia nėra";
	color:#4aaee7;
}

#user-rollover.id-4849359 .meta {
	height:140px !important;
}

#user-rollover.id-4849359 .meta .status:after {
	content:"\A" url('http://i.imgur.com/VzJXKT1.png') " RCS Owner";
	color: #7cbf00;
	margin-left: 4px;
	white-space: pre;
	font-size: 12px;
	position: relative;
	text-transform: uppercase;
	font-weight: 600;
	top:3px;
}

#user-rollover.id-4849359 .meta .joined {
	top:90px;
}

#user-rollover.id-4849359 .meta .showID {
	top:110px !important;
}

[data-cid^="4849359-"] .msg .from .un {
	position: relative;
	left: -1px;
	padding-left: 18px;
	background-image:url('http://i.imgur.com/qh3L2l9.png');
	background-repeat: no-repeat;
	background-position: -1px center;
	background-size: 15px auto;
	color:#7cbf00 !important;
}
*/
/*bot icon*/
#user-lists .user.id-32916305 .icon-chat-manager,
#user-rollover.id-32916305 .icon-chat-manager,
#chat .cm.id-32916305 .from .icon-chat-manager{
background-image: url(https://i.imgur.com/tmU1lnA.png);
background-position: 0;
}
/*bot tag*/
#user-lists .user.id-32916305 .name:after, 
#chat [data-cid^="32916305-"] .un:after, 
#user-rollover.id-32916305 .username:after {
content: 'BOT';
color: white;
font-size: 10px;
position: relative;
top: -1px;
Left: 5px;
padding-left: 3px;
padding-right: 3px;
background-color: rgba(0, 255, 255, 0.38);
border: 1px rgba(255, 255, 255, 0.5) solid;
}
#user-lists .user.id-32916305 .name:hover:after, 
#chat [data-cid^="32916305-"] .un:hover:after, 
#user-rollover.id-32916305 .username:hover:after {
background-color: rgba(0, 173, 255, 0.41);
}
/*badges*/
/*<3 Agátka <3*/
#user-rollover.id-24093324 .bdg,
[data-cid^="24093324-"] i.bdg {
    background: url("https://i.imgur.com/K86NCHv.gif") !important;
	background-size: 30px !important;
	border-radius: 6px;
}
/*mikano*/
#user-rollover.id-28844403 .bdg,
[data-cid^="28844403-"] i.bdg {
    background: url("https://i.imgur.com/2wnOzXr.gif") !important;
	background-size: 30px !important;
	border-radius: 6px;
}
