"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var adminpanel_service_1 = require("./adminpanel.service");
describe('AdminpanelService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(adminpanel_service_1.AdminpanelService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=adminpanel.service.spec.js.map