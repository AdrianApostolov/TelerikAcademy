﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" >
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="/">
    <html>
      <style>
        table {
        font-size: 20px;
        text-align: center;
        border: 1px solid black;
        border-collapse: collapse;
        }

        th, td {
        padding: 5px;
        border: 1px solid black;
        }

        th{
        background-color: skyblue;
        }

        td{
        background-color: gray;
        }
      </style>

      <body>
        <table>
          <tr>
            <th>Name</th>
            <th>Artist</th>
            <th>Year</th>
            <th>Producer</th>
            <th>Price</th>
            <th>Songs</th>
          </tr>
          <xsl:for-each select="catalog/album">
            <tr>
              <td>
                <xsl:value-of select="name" />
              </td>
              <td>
                <xsl:value-of select="artist" />
              </td>
              <td>
                <xsl:value-of select="year" />
              </td>
              <td>
                <xsl:value-of select="producer" />
              </td>
              <td>
                <xsl:value-of select="price" />
              </td>
              <td>
                <xsl:for-each select="songs/song">
                  <div>
                    <strong>
                      <xsl:value-of select="title"/>
                    </strong> -
                    <xsl:value-of select="duration"/>
                  </div>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
