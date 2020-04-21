import React, { Component } from 'react';
import QuantityType from '../ConversionUnits/QuantityUnitType';
import QuantityLeft from '../ConversionUnits//InputQuantityUnit';
import {FaEquals} from "react-icons/fa";
import QuantityRight from '../ConversionUnits//OutputQuantityUnit';
import {feetToInch, inchToFeet, meterToCentimeter, centimeterToMeter} from '../../Services/LengthConversionUnit';
import { kilogramToGram, gramToKilogram } from '../../Services/WeightConversionUnit';

class QuantityMeasurementUI extends Component {
    state = {
        showType: false,
        selectinputQuantity: "",
        selectoutputQuantity: "",
        inputQuantity: "",
        outputQuantity: ""
    }

    measurementTypeHandler = async (event) => {
        const type = event.target.value;
        console.log(type);
        if (type === "Length") {
            console.log('inside length');
           await this.setState({
                showType: true
            })
        }
        else if (type === "Weight") {
            console.log('inside weight');
           await this.setState({
                showType: false
            })
        }
    }

    selectInputChangeHandler = async (event) => {
        const selectinputQuantity = event.target.value;
         await this.setState({
            selectinputQuantity: selectinputQuantity
        })
    }

    selectOutputChangeHandler =  async (event) => {
        const selectoutputQuantity = event.target.value;
        await this.setState({
            selectoutputQuantity: selectoutputQuantity
        })
    }

    valueTypeOutputChangeHandler = async (event) => {
        const outputQuantityValue = event.target.value;
       await this.setState({
        outputQuantityValue: outputQuantityValue
        })
    }

    valueTypeInputChangeHandler =  async (event) => {
        const inputQuantity = event.target.value;
       await this.setState({
            inputQuantity: inputQuantity
        })
        console.log(this.state.inputQuantity);
        const input = this.state.inputQuantity;
        
        if((this.state.selectinputQuantity==="Feet") && (this.state.selectoutputQuantity==="Inch")){
            const data = {
                Feet: input
            }
            const response =  feetToInch(data);
            response.then(res=>{
                 this.setState({
                    outputQuantityValue:res.data
                })
            })
        }

        if((this.state.selectinputQuantity==="Inch") && (this.state.selectoutputQuantity==="Feet")){
            const data = {
                Inch: input
            }
            const response =  inchToFeet(data);
            response.then(res=>{
                 this.setState({
                    outputQuantityValue:res.data
                })
            })
        }

        if((this.state.selectinputQuantity==="Meter") && (this.state.selectoutputQuantity==="Centimeter")){
            const data = {
                Meter: input
            }
            const response =  meterToCentimeter(data);
            response.then(res=>{
                 this.setState({
                    outputQuantityValue:res.data
                })
            })
        }

        if((this.state.selectinputQuantity==="Centimeter") && (this.state.selectoutputQuantity==="Meter")){
            const data = {
                Centimeter: input
            }
            const response =  centimeterToMeter(data);
            response.then(res=>{
                 this.setState({
                    outputQuantityValue:res.data
                })
            })
        }

        if((this.state.selectinputQuantity==="Kilogram") && (this.state.selectoutputQuantity==="Gram")){
            const data = {
                Kilogram: input
            }
            const response =  kilogramToGram(data);
            response.then(res=>{
                 this.setState({
                    outputQuantityValue:res.data
                })
            })
        }

        if((this.state.selectinputQuantity==="Gram") && (this.state.selectoutputQuantity==="Kilogram")){
            const data = {
                Gram: input
            }
            const response =  gramToKilogram(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }
    }

    render() {
        return (
            <div className='main-div'>
                <QuantityUnitType measurementTypeChanged={this.measurementTypeHandler} />
                <div className='row'>
                    <InputQuantityUnit inputQuantityvalue={this.valueTypeInputChangeHandler} selectinputQuantity={this.selectInputChangeHandler} showType={this.state.showType} />
                <FaEquals className="equals-icon" />
                    <OutputQuantityUnit outputQuantityValue={this.valueTypeOutputChangeHandler} selectoutputQuantity={this.selectOutputChangeHandler}  valueRight={this.state.outputQuantityValue} showType={this.state.showType} />
                </div>
                //<Formula selectTypeLeft={this.state.selectTypeLeft} selectTypeRight={this.state.selectTypeRight}/>
            </div>
        )
    }
}
export default QuantityMeasurementUI