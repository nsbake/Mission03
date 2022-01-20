$("#calculate").click(function (e) {
    let finalGrade = parseFloat(($("#assign")[0].value * .55) + ($("#group")[0].value * .05) + ($("#quiz")[0].value * .1) + ($("#exam")[0].value * .2) + ($("#intex")[0].value * .1))

    $('#per').html(finalGrade)
    $('#Final').value(finalGrade)
})