<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:template match ="/">
    <html>
      <head>
        <link rel="stylesheet" type="text/css" href="file_newHotel.css" />
      </head>
      <body>
        <div class="tableParent">
          <table class="hotelsTable">
            <tr>
              <th>Name</th>
              <th>Rating</th>
              <th>Average Price Per Night</th>
            </tr>
            <xsl:apply-templates select="ArrayOfHotelListItem/HotelListItem">
              <xsl:sort select="Rating" order="descending"/>
            </xsl:apply-templates>
          </table>
        </div>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="HotelListItem">
    <tr>
      <td class="cellName">
        <xsl:value-of select="Name"/>
      </td>
      <td class="cellRating">
        <xsl:choose>
          <xsl:when test="Rating=0">
            <span class="rating-static rating-0"></span>
          </xsl:when>
          <xsl:when test="Rating=1">
            <span class="rating-static rating-10"></span>
          </xsl:when>
          <xsl:when test="Rating=2">
            <span class="rating-static rating-20"></span>
          </xsl:when>
          <xsl:when test="Rating=3">
            <span class="rating-static rating-30"></span>
          </xsl:when>
          <xsl:when test="Rating=4">
            <span class="rating-static rating-40"></span>
          </xsl:when>
          <xsl:when test="Rating=5">
            <span class="rating-static rating-50"></span>
          </xsl:when>
          <xsl:when test="Rating=0.5">
            <span class="rating-static rating-5"></span>
          </xsl:when>
          <xsl:when test="Rating=1.5">
            <span class="rating-static rating-15"></span>
          </xsl:when>
          <xsl:when test="Rating=2.5">
            <span class="rating-static rating-25"></span>
          </xsl:when>
          <xsl:when test="Rating=3.5">
            <span class="rating-static rating-35"></span>
          </xsl:when>
          <xsl:when test="Rating=4.5">
            <span class="rating-static rating-45"></span>
          </xsl:when>
        </xsl:choose>
      </td>
      <td class="cellRooms">
        <table style="border-collapse:collapse;white-space:nowrap; width:740px">
          <tr>
            <xsl:for-each select="RoomTypes/listItemRoom">
              <th class="cellRoomTypeTH">
                <xsl:value-of select="Type"/> = $<xsl:value-of select="DailyRate"/>
              </th>
            </xsl:for-each>
          </tr>
        </table>
      </td>
    </tr>

  </xsl:template>

</xsl:stylesheet>