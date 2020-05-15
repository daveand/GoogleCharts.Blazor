window.drawOrgChart = (config) => {
    return new Promise((resolve) => {
        google.charts.load('current', { packages: ["orgchart"] });
        google.charts.setOnLoadCallback(drawGoogleChart);

        function drawGoogleChart() {
            try {
                var dt = new google.visualization.DataTable();
                dt.addColumn('string', 'Entity');
                dt.addColumn('string', 'ParentEntity');
                dt.addColumn('string', 'ToolTip');
                for (var i = 0; i < config.data.length; i++) {
                    var memberId = config.data[i].memberId.toString();
                    var memberName = config.data[i].name;
                    var parentId = config.data[i].parentId !== null ? config.data[i].parentId.toString() : '';
                    dt.addRows([[{
                        v: memberId,
                        f: memberName
                    }, parentId, memberName]]);
                }
                var chart = new google.visualization.OrgChart(document.getElementById(config.id));
                chart.draw(dt, { allowHtml: true });
                resolve("");

            } catch (e) {
                resolve(e.stack);
            }
        }
    });
};

window.drawLineChart = (config) => {
    return new Promise((resolve) => {
        google.charts.load('current', { packages: ['corechart', 'line'] });
        google.charts.setOnLoadCallback(drawGoogleChart);

        function drawGoogleChart() {
            try {
                var dt = new google.visualization.DataTable();

                for (let i = 0; i < config.columns.length; i++) {
                    dt.addColumn(config.columns[i][0], config.columns[i][1]);
                }

                var rows = [];

                for (let i = 0; i < config.data.length; i++) {
                    let row = []
                    for (let j = 0; j < config.data[i].length; j++) {
                        row.push(config.data[i][j]);
                    }
                    rows.push(row);
                }

                dt.addRows(rows);

                var options = config.options;

                var chart = new google.visualization.LineChart(document.getElementById(config.id));
                chart.draw(dt, options);
                resolve("");

            } catch (e) {
                resolve(e.stack);
            }
        }
    });

};

