import QtQuick 2.12
import QtQuick.Window 2.12
import QtQuick.Layouts 1.0
import QtQuick.Controls 2.13
import QtQuick.Controls.Material 2.0

Window {
    id: window
    visible: true
    width: 1024
    height: 768
    color: "#444444"
    property alias wii_icon: wii_icon
    title: qsTr("GetMyBruQt")




    RowLayout {
        id: devices
        x: 40
        y: 252
        width: 1024
        height: 107
        spacing: 75
        anchors.verticalCenter: parent.verticalCenter
        anchors.horizontalCenter: parent.horizontalCenter

        Image {
            id: switch_icon
            scale: 0.8
            Layout.fillHeight: true
            Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
            Layout.fillWidth: true
            Layout.preferredHeight: 231
            Layout.preferredWidth: 247
            transformOrigin: Item.Center
            fillMode: Image.PreserveAspectFit
            source: "switch_icon_white.png"
        }

        Image {
            id: wiiu_icon
            scale: 0.75
            Layout.fillHeight: true
            Layout.fillWidth: true
            Layout.preferredHeight: 231
            Layout.preferredWidth: 247
            transformOrigin: Item.Center
            fillMode: Image.PreserveAspectFit
            source: "WiiU_White.png"
        }

        Image {
            id: wii_icon
            scale: 0.75
            Layout.fillHeight: true
            Layout.fillWidth: true
            Layout.preferredHeight: 231
            Layout.preferredWidth: 247
            transformOrigin: Item.Center
            fillMode: Image.PreserveAspectFit
            source: "Wii_White.png"
        }
    }

    Row {
        id: devices_text
        x: 0
        y: 436
        width: 1024
        height: 35
        anchors.horizontalCenter: parent.horizontalCenter
        spacing: 25

        Text {
            id: txt_switch
            x: 0
            width: 286
            height: 25
            color: "#ffffff"
            text: qsTr("Switch")
            fontSizeMode: Text.HorizontalFit
            elide: Text.ElideMiddle
            verticalAlignment: Text.AlignVCenter
            horizontalAlignment: Text.AlignHCenter
            font.pixelSize: 24
        }

        Text {
            id: txt_wiiu
            x: -57
            width: 400
            height: 25
            color: "#ffffff"
            text: qsTr("Wii U")
            fontSizeMode: Text.HorizontalFit
            elide: Text.ElideMiddle
            font.pixelSize: 24
            verticalAlignment: Text.AlignVCenter
            horizontalAlignment: Text.AlignHCenter
        }

        Text {
            id: txt_wii
            x: 1
            width: 285
            height: 25
            color: "#ffffff"
            text: qsTr("Wii")
            fontSizeMode: Text.HorizontalFit
            elide: Text.ElideMiddle
            font.pixelSize: 24
            horizontalAlignment: Text.AlignHCenter
            verticalAlignment: Text.AlignVCenter
        }
    }

    Text {
        id: txt_header
        width: 598
        height: 41
        color: "#ffffff"
        text: "Welcome, please choose a system to get started."
        anchors.left: parent.left
        anchors.leftMargin: 34
        anchors.top: parent.top
        anchors.topMargin: 122
        fontSizeMode: Text.HorizontalFit
        elide: Text.ElideMiddle
        font.pixelSize: 22
        horizontalAlignment: Text.AlignLeft
        verticalAlignment: Text.AlignVCenter
    }

    Text {
        id: txt_header_desc
        x: 34
        y: 169
        width: 598
        height: 104
        color: "#ffffff"
        text: "The options that are available for you to choose are, Switch, Wii U and Wii. Each option will allow you to install the Homebrew of that system to an SD card or USB Drive."
        font.pixelSize: 18
        wrapMode: Text.WordWrap
        fontSizeMode: Text.HorizontalFit
        elide: Text.ElideMiddle
        verticalAlignment: Text.AlignTop
        horizontalAlignment: Text.AlignLeft
    }

    Image {
        id: image
        x: 34
        y: 16
        width: 100
        height: 100
        fillMode: Image.PreserveAspectFit
        source: "Icon256.png"
    }

    RowLayout {
        id: devices_toggles
        x: 37
        y: 247
        width: 1024
        height: 107
        anchors.verticalCenterOffset: 133
        anchors.horizontalCenterOffset: 0
        anchors.horizontalCenter: parent.horizontalCenter
        anchors.verticalCenter: parent.verticalCenter
        spacing: 75

        RadioButton {
            id: rd_switch
            x: 117
            y: 497
            text: qsTr("")
            checked: true
            Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
            Layout.leftMargin: 0
            transformOrigin: Item.Left
        }

        RadioButton {
            id: rd_wiiu
            x: 117
            y: 497
            width: 46
            text: qsTr("")
            checkable: false
            Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
            Layout.margins: 0
            Layout.rowSpan: 1
            Layout.leftMargin: 0
            transformOrigin: Item.Left
        }

        RadioButton {
            id: rd_wii
            x: 117
            y: 497
            text: qsTr("")
            Layout.rightMargin: -1
            checkable: false
            Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
            Layout.leftMargin: 0
            transformOrigin: Item.Left
        }
    }

    Pane {
        id: pane
        y: 674
        height: 2
        anchors.right: parent.right
        anchors.rightMargin: 20
        anchors.left: parent.left
        anchors.leftMargin: 20
        leftPadding: 12
        transformOrigin: Item.Bottom
        anchors.bottom: parent.bottom
        anchors.bottomMargin: 92
    }

    Row {
        id: row
        y: 674
        width: 1024
        height: 94
        anchors.right: parent.right
        anchors.rightMargin: 0
        anchors.left: parent.left
        anchors.leftMargin: 0
        anchors.bottom: parent.bottom
        anchors.bottomMargin: 0

        Window {
            id: window1
            width: 1024
            height: 768
            color: "#444444"
            RowLayout {
                id: devices1
                x: 40
                y: 252
                width: 1024
                height: 107
                Image {
                    id: switch_icon1
                    fillMode: Image.PreserveAspectFit
                    Layout.fillHeight: true
                    Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
                    scale: 0.8
                    Layout.fillWidth: true
                    source: "switch_icon_white.png"
                    Layout.preferredWidth: 247
                    Layout.preferredHeight: 231
                    transformOrigin: Item.Center
                }

                Image {
                    id: wiiu_icon1
                    fillMode: Image.PreserveAspectFit
                    Layout.fillHeight: true
                    scale: 0.75
                    Layout.fillWidth: true
                    source: "WiiU_White.png"
                    Layout.preferredWidth: 247
                    Layout.preferredHeight: 231
                    transformOrigin: Item.Center
                }

                Image {
                    id: wii_icon1
                    fillMode: Image.PreserveAspectFit
                    Layout.fillHeight: true
                    scale: 0.75
                    Layout.fillWidth: true
                    source: "Wii_White.png"
                    Layout.preferredWidth: 247
                    Layout.preferredHeight: 231
                    transformOrigin: Item.Center
                }
                spacing: 75
                anchors.verticalCenter: parent.verticalCenter
                anchors.horizontalCenter: parent.horizontalCenter
            }

            Text {
                id: txt_header1
                width: 598
                height: 41
                color: "#ffffff"
                text: "Welcome, please choose a system to get started."
                font.pixelSize: 22
                anchors.top: parent.top
                verticalAlignment: Text.AlignVCenter
                anchors.left: parent.left
                fontSizeMode: Text.HorizontalFit
                anchors.topMargin: 122
                horizontalAlignment: Text.AlignLeft
                anchors.leftMargin: 34
                elide: Text.ElideMiddle
            }

            Text {
                id: txt_header_desc1
                x: 34
                y: 169
                width: 598
                height: 104
                color: "#ffffff"
                text: "The options that are available for you to choose are, Switch, Wii U and Wii. Each option will allow you to install the Homebrew of that system to an SD card or USB Drive."
                font.pixelSize: 18
                verticalAlignment: Text.AlignTop
                fontSizeMode: Text.HorizontalFit
                horizontalAlignment: Text.AlignLeft
                wrapMode: Text.WordWrap
                elide: Text.ElideMiddle
            }

            Image {
                id: image1
                x: 34
                y: 16
                width: 100
                height: 100
                fillMode: Image.PreserveAspectFit
                source: "Icon256.png"
            }

            RowLayout {
                id: devices_toggles1
                x: 37
                y: 247
                width: 1024
                height: 107
                anchors.horizontalCenterOffset: 0
                RadioButton {
                    id: rd_switch1
                    x: 117
                    y: 497
                    text: qsTr("")
                    checked: true
                    Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
                    transformOrigin: Item.Left
                    Layout.leftMargin: 0
                }

                RadioButton {
                    id: rd_wiiu1
                    x: 117
                    y: 497
                    width: 46
                    text: qsTr("")
                    checkable: false
                    Layout.margins: 0
                    Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
                    Layout.rowSpan: 1
                    transformOrigin: Item.Left
                    Layout.leftMargin: 0
                }

                RadioButton {
                    id: rd_wii1
                    x: 117
                    y: 497
                    text: qsTr("")
                    checkable: false
                    Layout.rightMargin: -1
                    Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
                    transformOrigin: Item.Left
                    Layout.leftMargin: 0
                }
                spacing: 75
                anchors.horizontalCenter: parent.horizontalCenter
                anchors.verticalCenter: parent.verticalCenter
                anchors.verticalCenterOffset: 133
            }

            Pane {
                id: pane1
                y: 674
                height: 2
                leftPadding: 12
                anchors.rightMargin: 20
                anchors.bottom: parent.bottom
                anchors.left: parent.left
                anchors.bottomMargin: 92
                anchors.leftMargin: 20
                anchors.right: parent.right
                transformOrigin: Item.Bottom
            }

            Row {
                id: footer
                y: 674
                width: 1024
                height: 94
                anchors.rightMargin: 0
                anchors.left: parent.left
                anchors.bottom: parent.bottom
                anchors.bottomMargin: 0
                anchors.leftMargin: 0
                anchors.right: parent.right

                Button {
                    id: btn_submit
                    x: 891
                    y: 701
                    text: qsTr("Next")
                    anchors.rightMargin: 33
                    flat: false
                    anchors.bottom: parent.bottom
                    anchors.bottomMargin: 27
                    layer.smooth: false
                    hoverEnabled: false
                    anchors.right: parent.right
                    transformOrigin: Item.BottomRight
                }

                Button {
                    id: btn_exit
                    x: 758
                    y: 701
                    text: qsTr("Exit")
                    anchors.rightMargin: 166
                    flat: false
                    anchors.bottom: parent.bottom
                    anchors.bottomMargin: 27
                    hoverEnabled: false
                    layer.smooth: false
                    anchors.right: parent.right
                    transformOrigin: Item.BottomRight
                }

                BusyIndicator {
                    id: busy
                    x: 705
                    y: 696
                    width: 47
                    height: 50
                    visible: false
                    anchors.rightMargin: 272
                    wheelEnabled: false
                    anchors.bottom: parent.bottom
                    anchors.bottomMargin: 22
                    anchors.right: parent.right
                    transformOrigin: Item.BottomRight
                }

                Image {
                    id: switch_icon_footer
                    y: 686
                    width: 85
                    height: 70
                    fillMode: Image.PreserveAspectFit
                    anchors.bottom: parent.bottom
                    anchors.left: parent.left
                    anchors.bottomMargin: 12
                    Layout.fillHeight: true
                    anchors.leftMargin: 26
                    Layout.alignment: Qt.AlignHCenter | Qt.AlignVCenter
                    scale: 0.8
                    source: "switch_icon_white.png"
                    Layout.fillWidth: true
                    Layout.preferredWidth: 247
                    Layout.preferredHeight: 231
                    transformOrigin: Item.Center
                }
            }
            visible: true
            title: qsTr("GetMyBruQt")
        }
    }
}

/*##^##
Designer {
    D{i:0;formeditorZoom:0.6600000262260437}D{i:1;anchors_x:40;anchors_y:252}D{i:6;anchors_x:0}
D{i:5;anchors_width:1024;anchors_x:0}D{i:9;anchors_x:34;anchors_y:122}D{i:12;anchors_x:40;anchors_y:252}
D{i:16;anchors_height:2;anchors_width:1019;anchors_x:0;anchors_y:685}D{i:19;anchors_x:40;anchors_y:252}
D{i:23;anchors_x:34;anchors_y:122}D{i:26;anchors_x:40;anchors_y:252}D{i:30;anchors_height:2;anchors_width:1019;anchors_x:0;anchors_y:685}
D{i:18;formeditorZoom:0.75}
}
##^##*/
