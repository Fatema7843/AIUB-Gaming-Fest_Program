// Data retrieved from https://netmarketshare.com/
// Build the chart

$(document).ready(function () {
    $.ajax({
        type: "POST",
        url: 'Admin/Overview',
        data: JSON.stringify({}),
        contentType: "application/json:charset=utf-8",
        dataType: "json",
        success: function (json) {
            var values = json.Overview_dashboard;
            var malecount = parseInt(values[0]);
            var femalecount = parseInt(values[1]);


            Highcharts.chart('container', {
                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: null,
                    plotShadow: false,
                    type: 'pie'
                },
                title: {
                    text: 'Overview of the scenario that how many users are registration',
                    align: 'left'
                },
                tooltip: {
                    pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                },
                accessibility: {
                    point: {
                        valueSuffix: '%'
                    }
                },
                plotOptions: {
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: false
                        },
                        showInLegend: true
                    }
                },
                series: [{
                    name: 'Count',
                    colorByPoint: true,
                    data: [{
                        name: 'Male',
                        y: malecount,
                        sliced: true,
                        selected: true
                    }, {
                        name: 'Female',
                        y: femalecount
                    }]
                }]
            });


        }




    })












});








































