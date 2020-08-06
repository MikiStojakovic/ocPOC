"use strict";

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

function createStatementData(invoice, plays) {
  var result = {};
  result.customer = invoice.customer;
  result.performances = invoice.performances.map(enrichPerformance);
  result.totalAmount = totalAmount(result);
  result.totalVolumeCredits = totalVolumeCredits(result);
  return result;

  function enrichPerformance(aPerformance) {
    var calculator = new PerformanceCalculator(aPerformance, playFor(aPerformance));
    var result = Object.assign({}, aPerformance);
    result.play = calculator.play;
    result.amount = amountFor(result);
    result.volumeCredits = volumeCreditsFor(result);
    return result;
  }

  function playFor(aPerformance) {
    return plays[aPerformance.playID];
  }

  function amountFor(aPerformance) {
    var result = 0;

    switch (aPerformance.play.type) {
      case 'tragedy':
        result = 40000;

        if (aPerformance.audience > 30) {
          result += 1000 * (aPerformance.audience - 30);
        }

        break;

      case 'comedy':
        result = 30000;

        if (aPerformance.audience > 20) {
          result += 10000 + 500 * (aPerformance.audience - 20);
        }

        result += 300 * aPerformance.audience;
        break;

      default:
        throw new Error("unknown type: ".concat(playFor(aPerformance).type));
    }

    return result;
  }

  function volumeCreditsFor(perf) {
    var result = 0;
    result += Math.max(perf.audience - 30, 0); // add extra credit for every ten comedy attendees

    if ('comedy' === perf.play.type) result += Math.floor(perf.audience / 5);
    return result;
  }

  function totalAmount(data) {
    return data.performances.reduce(function (total, p) {
      return total + p.amount;
    }, 0);
  }

  function totalVolumeCredits(data) {
    return data.performances.reduce(function (total, p) {
      return total + p.volumeCredits;
    }, 0);
  }
}

var PerformanceCalculator = /*#__PURE__*/function () {
  function PerformanceCalculator(aPerformance, aPlay) {
    _classCallCheck(this, PerformanceCalculator);

    this.performance = aPerformance;
    this.play = aPlay;
  }

  _createClass(PerformanceCalculator, [{
    key: "amount",
    get: function get() {
      var result = 0;

      switch (this.play.type) {
        case 'tragedy':
          result = 40000;

          if (this.performance.audience > 30) {
            result += 1000 * (this.performance.audience - 30);
          }

          break;

        case 'comedy':
          result = 30000;

          if (this.performance.audience > 20) {
            result += 10000 + 500 * (this.performance.audience - 20);
          }

          result += 300 * this.performance.audience;
          break;

        default:
          throw new Error("unknown type: ".concat(this.play.type));
      }

      return result;
    }
  }]);

  return PerformanceCalculator;
}();

module.exports = {
  createStatementData: createStatementData
};