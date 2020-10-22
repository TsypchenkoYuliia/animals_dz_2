"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var home_service_1 = require("./home.service");
describe('HomeService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(home_service_1.HomeService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=home.service.spec.js.map