function searchFlights() {
    var flights = [
      // { id: 1, name: 'پرواز شماره 1' },
      // { id: 2, name: 'پرواز شماره 2' },
      // { id: 3, name: 'پرواز شماره 3' }
    ];
    var select = document.getElementById("selectedFlight");
    select.innerHTML = "";
    for (var i = 0; i < flights.length; i++) {
      var option = document.createElement("option");
      option.value = flights[i].id;
      option.text = flights[i].name;
      select.appendChild(option);
    }
    document.getElementById("reservationForm").style.display = "block";
  }

  function reserveFlight() {
    var selectedFlightId = document.getElementById("selectedFlight").value;
    var passengerName = document.getElementById("passengerName").value;
    var nationalCode = document.getElementById("nationalCode").value;

    alert("بلیط با شماره " + selectedFlightId + " برای " + passengerName + " با موفقیت رزرو شد!");
  }
