﻿@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<script type="text/javascript">
    function OnBeginCallback(s, e) {
        var container = $(s.GetMainElement());
        var token = $('input[name="__RequestVerificationToken"]', container).val();
        e.customArgs["__RequestVerificationToken"] = token;
    }
</script>
@Html.Action("GridViewPartial")